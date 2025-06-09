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

            this.KeyPreview = true;
            this.KeyDown += AddEditMovieForm_KeyDown;

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
                    Rating = movie.Rating,
                    Duration = movie.Duration,
                    Description = movie.Description,
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

        private void AddEditMovieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
            else if(e.KeyCode == Keys.F1)
            {
                MessageBox.Show("This is a form of adding or editing a movie. Fill in all required fields, then click:\n Enter - Agree\n Esc - Refuse\n Tab – Move to the next field\n Shift-Tab – return to the previous field.",
                                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillFormWithMovie(Movie movie)
        {
            txtTitle.Text = movie.Title;
            txtStudio.Text = movie.Studio;
            txtGenre.Text = movie.Genre;
            numYear.Value = movie.Year;
            txtCountry.Text = movie.Country;
            txtDirector.Text = movie.Director;
            txtActors.Text = movie.MainActors;
            numDuration.Value = movie.Duration;
            numRating.Value = (decimal)movie.Rating;
            txtDescription.Text = movie.Description;
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
            Movie.Studio = txtStudio.Text.Trim();
            Movie.Genre = txtGenre.Text.Trim();
            Movie.Year = (int)numYear.Value;
            Movie.Country = txtCountry.Text.Trim();
            Movie.Director = txtDirector.Text.Trim();
            Movie.MainActors = txtActors.Text.Trim();
            Movie.Duration = (int)numDuration.Value;
            Movie.Rating = (int)numRating.Value;
            Movie.Description = txtDescription.Text.Trim();
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
