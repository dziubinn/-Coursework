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

                Movie = new Movie
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Studio = movie.Studio,
                    Genre = movie.Genre,
                    Year = movie.Year,
                    Country = movie.Country,
                    Director = movie.Director,
                    MainActors = movie.MainActors,
                    Description = movie.Description,
                    Rating = movie.Rating,
                    Duration = movie.Duration,
                    Watched = movie.Watched,
                    IsFavorite = movie.IsFavorite
                };

                FillFormWithMovie(Movie);
            }
            else
            {
                isEditMode = false;
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
            numRating.Value = (decimal)movie.Rating;

            chkWatched.Checked = movie.Watched;
            chkFavorite.Checked = movie.IsFavorite;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtStudio.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtDirector.Text) ||
                string.IsNullOrWhiteSpace(txtActors.Text))
            {
                MessageBox.Show("Please fill in all required fields: Title, Studio, Genre, Country, Director, and Main Actors.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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
