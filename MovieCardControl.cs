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

    private void InitializeComponents()
    {
        this.Size = new Size(300, 80);
        this.BorderStyle = BorderStyle.FixedSingle;
        this.BackColor = Color.White;

        lblTitleYearGenre = new Label();
        lblTitleYearGenre.Location = new Point(10, 10);
        lblTitleYearGenre.Size = new Size(220, 60);
        lblTitleYearGenre.Font = new Font("Arial", 10, FontStyle.Bold);
        lblTitleYearGenre.AutoEllipsis = true;
        lblTitleYearGenre.TextAlign = ContentAlignment.MiddleLeft;

        btnDetails = new Button();
        btnDetails.Size = new Size(40, 40);
        btnDetails.Location = new Point(240, 20);
        btnDetails.Text = "i";
        btnDetails.Font = new Font("Bauhaus 93", 12, FontStyle.Bold);
        btnDetails.FlatStyle = FlatStyle.Popup;
        btnDetails.Click += BtnDetails_Click;

        this.Controls.Add(lblTitleYearGenre);
        this.Controls.Add(btnDetails);
    }

    public void SetMovie(Movie movie)
    {
        currentMovie = movie;
        lblTitleYearGenre.Text = $"{movie.Title} {movie.Year} {movie.Genre}";
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
