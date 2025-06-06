using System;
using System.Windows.Forms;
using Сoursework.Models;

namespace Сoursework
{
    public partial class MovieDetailsForm : Form
    {
        private Movie _movie;

        public MovieDetailsForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            DisplayMovieDetails();
        }

        private void DisplayMovieDetails()
        {
            lblTitle.Text = _movie.Title;
            lblYear.Text = _movie.Year.ToString();
            lblGenre.Text = _movie.Genre;
            lblRating.Text = _movie.Rating.ToString("0.0");
            lblDirector.Text = _movie.Director;
            lblCountry.Text = _movie.Country;
            lblMainActor.Text = _movie.MainActors;
            lblDuration.Text = _movie.Duration.ToString() + " min";
            lblStudio.Text = _movie.Studio;
        }
    }
}
