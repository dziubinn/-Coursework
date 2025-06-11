using System;
using System.Drawing;
using System.Windows.Forms;
using Сoursework.Models;
using Сoursework;

public class MovieCardControl : UserControl
{
    private bool isSelected;
    private bool isFavorite = false;
    private Color originalBackColor;
    private Label lblTitleYearGenre;
    private Button btnDetails;
    private Button btnFavorite;
    private Movie currentMovie;
    public Movie Movie { get; private set; }

    public bool IsSelected
    {
        get => isSelected;
        set
        {
            isSelected = value;
            this.BackColor = isSelected ? Color.AntiqueWhite : originalBackColor;
        }
    }

    public MovieCardControl()
    {
        InitializeComponents();
        originalBackColor = this.BackColor;

        this.Click += MovieCardControl_Click;
        foreach (Control control in this.Controls)
        {
            control.Click += MovieCardControl_Click;
        }
    }

    private Label lblTitle;
    private Label lblInfo;
    private Label lblRating;

    private void InitializeComponents()
    {
        this.Size = new Size(300, 100);
        this.BorderStyle = BorderStyle.FixedSingle;
        this.BackColor = Color.White;

        lblTitle = new Label();
        lblTitle.Location = new Point(10, 5);
        lblTitle.Size = new Size(220, 25);
        lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblTitle.AutoEllipsis = true;
        lblTitle.UseCompatibleTextRendering = true;

        lblInfo = new Label();
        lblInfo.Location = new Point(10, 30);
        lblInfo.Size = new Size(220, 20);
        lblInfo.Font = new Font("Arial", 9, FontStyle.Regular);
        lblInfo.ForeColor = Color.DimGray;
        lblInfo.TextAlign = ContentAlignment.MiddleLeft;

        lblRating = new Label();
        lblRating.Location = new Point(10, 55);
        lblRating.Size = new Size(220, 20);
        lblRating.Font = new Font("Arial", 9, FontStyle.Italic);
        lblRating.ForeColor = Color.DarkOrange;
        lblRating.TextAlign = ContentAlignment.MiddleLeft;

        btnDetails = new Button();
        btnDetails.Size = new Size(40, 30);
        btnDetails.Location = new Point(250, 10);
        btnDetails.Text = "i";
        btnDetails.Font = new Font("Bauhaus 93", 12, FontStyle.Bold);
        btnDetails.FlatStyle = FlatStyle.Popup;
        btnDetails.Click += BtnDetails_Click;

        btnFavorite = new Button();
        btnFavorite.Size = new Size(40, 50);
        btnFavorite.Location = new Point(250, 45);
        btnFavorite.Text = "♡";
        btnFavorite.Font = new Font("Arial", 28, FontStyle.Bold);
        btnFavorite.ForeColor = Color.Gray;
        btnFavorite.FlatStyle = FlatStyle.Flat;
        btnFavorite.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btnFavorite.FlatAppearance.MouseDownBackColor = Color.Transparent;
        btnFavorite.BackColor = Color.Transparent;
        btnFavorite.FlatAppearance.BorderSize = 0;
        btnFavorite.Click += BtnFavorite_Click;

        this.Controls.Add(lblTitle);
        this.Controls.Add(lblInfo);
        this.Controls.Add(lblRating);
        this.Controls.Add(btnDetails);
        this.Controls.Add(btnFavorite);
    }

    public void SetMovie(Movie movie, List<Movie> globalFavorites = null)
    {
        currentMovie = movie;
        Movie = movie;

        lblTitle.Text = movie.Title;
        lblInfo.Text = $"{movie.Year}  {movie.Duration}m  {movie.Genre}";
        lblRating.Text = $"★ {movie.Rating:F1}";

        if (globalFavorites != null && globalFavorites.Contains(movie))
        {
            isFavorite = true;
            btnFavorite.Text = "♥";
            btnFavorite.ForeColor = Color.Firebrick;
        }
        else
        {
            isFavorite = false;
            btnFavorite.Text = "♡";
            btnFavorite.ForeColor = Color.Gray;
        }
    }

    private void BtnDetails_Click(object sender, EventArgs e)
    {
        if (currentMovie != null)
        {
            var detailsForm = new MovieDetailsForm(currentMovie);
            detailsForm.ShowDialog();
        }
    }

    private void BtnFavorite_Click(object sender, EventArgs e)
    {
        isFavorite = !isFavorite;
        btnFavorite.Text = isFavorite ? "♥" : "♡";
        btnFavorite.ForeColor = isFavorite ? Color.Firebrick : Color.Gray;

        if (isFavorite)
            FavoriteAdded?.Invoke(this, currentMovie);
        else
            FavoriteRemoved?.Invoke(this, currentMovie);
    }
    public event EventHandler<Movie> FavoriteAdded;
    public event EventHandler<Movie> FavoriteRemoved;

    public event EventHandler Selected;

    private void MovieCardControl_Click(object sender, EventArgs e)
    {
        Selected?.Invoke(this, EventArgs.Empty);
    }

    public void ShowDetails()
    {
        btnDetails.PerformClick();
    }
    public bool IsFavorite
    {
        get => isFavorite;
        set
        {
            isFavorite = value;
            btnFavorite.Text = isFavorite ? "♥" : "♡";
            btnFavorite.ForeColor = isFavorite ? Color.Firebrick : Color.Gray;
        }
    }
    public void SetFavorite(bool favorite)
    {
        IsFavorite = favorite;
    }
}
