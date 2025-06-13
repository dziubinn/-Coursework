using System;
using System.Windows.Forms;
using Сoursework.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Сoursework
{
    /// <summary>Форма для додавання або редагування інформації про фільм.</summary>
    public partial class AddEditMovieForm : Form
    {
        /// <summary>Отримує або встановлює об'єкт фільму, який створюється або редагується у формі.</summary>
        public Movie Movie { get; private set; }

        private bool isEditMode;

        /// <summary>
        /// Ініціалізує новий екземпляр форми для додавання або редагування фільму.
        /// Якщо переданий фільм не null — форма працює в режимі редагування.
        /// </summary>
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

        /// <summary>
        /// Обробник події натискання клавіш на формі. Реагує на клавіші Esc (відміна), Enter (підтвердження) та F1 (допомога).
        /// </summary>
        private void AddEditMovieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
            else if(e.KeyCode == Keys.F1)
            {
                MessageBox.Show("This is a form of adding or editing a movie. Fill in all required fields, then click:\nEnter - Agree\nEsc - Refuse\nTab – Move to the next field\nShift-Tab – return to the previous field.",
                                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>Заповнює поля форми інформацією із переданого об'єкта фільму.</summary>
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
            chkFavorite.Checked = movie.IsFavorite;
        }

        /// <summary>
        /// Обробник події натискання кнопки "ОК".
        /// Перевіряє валідність введених даних, оновлює об'єкт Movie і закриває форму з результатом OK.</summary>
        private void btnSave_Click(object sender, EventArgs e)
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
            Movie.IsFavorite = chkFavorite.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>Обробник події натискання кнопки "Відміна". Закриває форму без збереження змін.</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
