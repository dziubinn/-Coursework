using System;
using System.Drawing;
using System.Windows.Forms;
using Сoursework.Models;
using Сoursework;

public class MovieCardControl : UserControl
{
    private Label lblTitleYearGenre;
    private Button btnDetails;

    private Movie currentMovie;

    public MovieCardControl()
    {
        InitializeComponents();
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
        btnDetails.Size = new Size(40, 40);
        btnDetails.Location = new Point(240, 25);
        btnDetails.Text = "i";
        btnDetails.Font = new Font("Bauhaus 93", 12, FontStyle.Bold);
        btnDetails.FlatStyle = FlatStyle.Popup;
        btnDetails.Click += BtnDetails_Click;

        this.Controls.Add(lblTitle);
        this.Controls.Add(lblInfo);
        this.Controls.Add(lblRating);
        this.Controls.Add(btnDetails);
    }


    public void SetMovie(Movie movie)
    {
        currentMovie = movie;

        lblTitle.Text = movie.Title;
        lblInfo.Text = $"{movie.Year}  {movie.Duration}m  {movie.Genre}";
        lblRating.Text = $"★ {movie.Rating:F1}";
    }


    private void BtnDetails_Click(object sender, EventArgs e)
    {
        if (currentMovie != null)
        {
            var detailsForm = new MovieDetailsForm(currentMovie);
            detailsForm.ShowDialog();
        }
    }
}
