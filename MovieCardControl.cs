using System;
using System.Drawing;
using System.Windows.Forms;
using Сoursework.Models;
using Сoursework;

/// <summary>
/// Візуальний елемент керування для відображення інформації про фільм у вигляді картки.
/// Містить назву, рік, жанр, рейтинг, кнопки деталей та улюбленого.
/// </summary>
public class MovieCardControl : UserControl
{
    private bool isSelected;
    private bool isFavorite = false;
    private Color originalBackColor;
    private Label lblTitleYearGenre;
    private Button btnDetails;
    private Button btnFavorite;
    private Movie currentMovie;

    /// <summary>Отримує фільм, представлений цією карткою.</summary>
    public Movie Movie { get; private set; }

    /// <summary>Вказує, чи є картка вибраною. Змінює колір фону.</summary>
    public bool IsSelected
    {
        get => isSelected;
        set
        {
            isSelected = value;
            this.BackColor = isSelected ? Color.OldLace : originalBackColor;
        }
    }

    /// <summary>Ініціалізує новий екземпляр елемента керування карткою фільму.</summary>
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

    /// <summary>Ініціалізує всі графічні компоненти картки.</summary>
    private void InitializeComponents()
    {
        this.Size = new Size(300, 100);
        this.BorderStyle = BorderStyle.FixedSingle;
        this.BackColor = Color.White;

        lblTitle = new Label();
        lblTitle.Location = new Point(10, 5);
        lblTitle.Size = new Size(220, 25);
        lblTitle.Font = new Font("Belwe Bd BT", 12, FontStyle.Bold);
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblTitle.AutoEllipsis = true;
        lblTitle.UseCompatibleTextRendering = true;

        lblInfo = new Label();
        lblInfo.Location = new Point(10, 30);
        lblInfo.Size = new Size(220, 20);
        lblInfo.Font = new Font("Belwe Bd BT", 9, FontStyle.Regular);
        lblInfo.ForeColor = Color.DimGray;
        lblInfo.TextAlign = ContentAlignment.MiddleLeft;

        lblRating = new Label();
        lblRating.Location = new Point(10, 55);
        lblRating.Size = new Size(220, 20);
        lblRating.Font = new Font("Belwe Bd BT", 11, FontStyle.Italic);
        lblRating.ForeColor = Color.DarkOrange;
        lblRating.TextAlign = ContentAlignment.MiddleLeft;

        btnDetails = new Button();
        btnDetails.Size = new Size(40, 30);
        btnDetails.Location = new Point(250, 10);
        btnDetails.Text = "i";
        btnDetails.Font = new Font("Belwe Bd BT", 12, FontStyle.Bold);
        btnDetails.FlatStyle = FlatStyle.Popup;
        btnDetails.Click += BtnDetails_Click;

        btnFavorite = new Button();
        btnFavorite.Size = new Size(40, 50);
        btnFavorite.Location = new Point(250, 45);
        btnFavorite.Text = "♡";
        btnFavorite.Font = new Font("Belwe Bd BT", 24, FontStyle.Bold);
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

    /// <summary>Встановлює фільм для відображення в картці.</summary>
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

    /// <summary>Відкриває вікно з деталями про фільм.</summary>
    private void BtnDetails_Click(object sender, EventArgs e)
    {
        if (currentMovie != null)
        {
            var detailsForm = new MovieDetailsForm(currentMovie);
            detailsForm.ShowDialog();
        }
    }

    /// <summary>Перемикає статус улюбленого фільму при натисканні кнопки.</summary>
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

    /// <summary>Подія, яка виникає при додаванні фільму до улюблених.</summary>
    public event EventHandler<Movie> FavoriteAdded;

    /// <summary>Подія, яка виникає при видаленні фільму з улюблених.</summary>
    public event EventHandler<Movie> FavoriteRemoved;

    /// <summary>Подія, яка виникає при виборі картки користувачем.</summary>
    public event EventHandler Selected;

    /// <summary>Обробляє клік миші по картці — активує подію вибору.</summary>
    private void MovieCardControl_Click(object sender, EventArgs e)
    {
        Selected?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>Відображає вікно з деталями фільму (симуляція кліку по кнопці деталей).</summary>
    public void ShowDetails()
    {
        btnDetails.PerformClick();
    }

    /// <summary>Показує чи приховує статус "улюбленого" фільму на картці.</summary>
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
}
