using System;
using System.Windows.Forms;
using Сoursework.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Сoursework
{
    public partial class AddEditMovieForm : Form
    {
        public Movie Movie { get; private set; }

        private bool isEditMode;

        public AddEditMovieForm(Movie movie = null)
        {
            InitializeComponent();
            if (movie != null)
            {
                isEditMode = true;
                Text = "Edit Movie";
                Movie = movie;
                FillFormWithMovie(movie);
            }
            else
            {
                Text = "Add Movie";
                Movie = new Movie();
            }
        }

        private void FillFormWithMovie(Movie movie)
        {
            txtTitle.Text = movie.Title;
            txtDirector.Text = movie.Director;
            txtGenre.Text = movie.Genre;
            txtCountry.Text = movie.Country;
            txtStudio.Text = movie.Studio;
            txtActors.Text = movie.MainActors;
            txtDescription.Text = movie.Description;

            numYear.Value = movie.Year;
            numDuration.Value = movie.Duration;
            numRating.Value = movie.Rating;

            chkWatched.Checked = movie.Watched;
            chkFavorite.Checked = movie.IsFavorite;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Movie.Title = txtTitle.Text.Trim();
            Movie.Director = txtDirector.Text.Trim();
            Movie.Genre = txtGenre.Text.Trim();
            Movie.Country = txtCountry.Text.Trim();
            Movie.Studio = txtStudio.Text.Trim();
            Movie.MainActors = txtActors.Text.Trim();
            Movie.Description = txtDescription.Text.Trim();

            Movie.Year = (int)numYear.Value;
            Movie.Duration = (int)numDuration.Value;
            Movie.Rating = (int)numRating.Value;

            Movie.Watched = chkWatched.Checked;
            Movie.IsFavorite = chkFavorite.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
