using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сoursework.Models;

namespace Сoursework
{
    public partial class MainForm : Form
    {
        private MovieLibrary movieLibrary = new MovieLibrary();
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "movies.json");
            movieLibrary.LoadFromFile(filePath);
            movies = movieLibrary.GetAllMovies();
            txtSearch.KeyDown += TxtSearch_KeyDown;

            cmbFilterBy.Items.Clear();
            cmbFilterBy.Items.AddRange(new string[]
            {
                "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio"
            });

            RefreshMovieCards();
        }

        private void RefreshMovieCards(List<Movie> moviesToDisplay = null)
        {
            flowPanelMovies.Controls.Clear();

            var movies = moviesToDisplay ?? movieLibrary.GetAllMovies();

            foreach (var movie in movies)
            {
                var card = new MovieCardControl();
                card.SetMovie(movie);

                card.Selected += MovieCardControl_Selected;

                flowPanelMovies.Controls.Add(card);
            }
        }

        private void MovieCardControl_Selected(object sender, EventArgs e)
        {
            foreach (var otherCard in flowPanelMovies.Controls.OfType<MovieCardControl>())
                otherCard.IsSelected = false;

            if (sender is MovieCardControl selectedCard) 
                selectedCard.IsSelected = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditMovieForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    movieLibrary.AddMovie(form.Movie);
                    movies = movieLibrary.GetAllMovies();
                    RefreshMovieCards();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var selectedCard = flowPanelMovies.Controls
                .OfType<MovieCardControl>()
                .FirstOrDefault(c => c.IsSelected);

            if (selectedCard == null)
            {
                MessageBox.Show("Choose movie first");
                return;
            }

            var selectedMovie = selectedCard.Movie;

            var editForm = new AddEditMovieForm(selectedMovie);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                movieLibrary.UpdateMovie(editForm.Movie);
                RefreshMovieCards();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCard = flowPanelMovies.Controls
                .OfType<MovieCardControl>()
                .FirstOrDefault(c => c.IsSelected);
            
            if (selectedCard == null)
            {
                MessageBox.Show("Choose movie first");
                return;
            }

            var selectedMovie = selectedCard.Movie;
            var confirmResult = MessageBox.Show($"Are you sure you want to delete this movie:\n\n{selectedMovie.Title}?",
                "Delete confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(confirmResult == DialogResult.Yes)
            {
                movieLibrary.DeleteMovie(selectedMovie);
                RefreshMovieCards();
            }
        }

        private List<Movie> movies = new List<Movie>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            var filteredMovies = movies
                .Where(m => m.Title.ToLower().Contains(searchTerm))
                .ToList();

            if (filteredMovies.Count == 0)
            {
                flowPanelMovies.Controls.Clear();
                Label noResults = new Label
                {
                    Text = "No movies found",
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Font = new Font("Arial", 13, FontStyle.Bold),
                    Padding = new Padding(10)
                };
                flowPanelMovies.Controls.Add(noResults);
            }
            else
            {
                RefreshMovieCards(filteredMovies);
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnSearch.PerformClick();
            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilterValue.Items.Clear();
            string selectedCriterion = cmbFilterBy.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCriterion)) return;

            List<string> values = new List<string>();

            switch (selectedCriterion)
            {
                case "Genre":
                    values = movieLibrary.GetAllMovies()
                        .Where(m => !string.IsNullOrWhiteSpace(m.Genre))
                        .SelectMany(m => m.Genre.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                        .Select(g => g.Trim())
                        .Distinct()
                        .OrderBy(g => g)
                        .ToList();
                    break;

                case "Year":
                    values = movieLibrary.GetAllMovies()
                        .Select(m => m.Year.ToString())
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
                    break;

                case "Director":
                    values = movieLibrary.GetAllMovies()
                        .Where(m => !string.IsNullOrWhiteSpace(m.Director))
                        .SelectMany(m => m.Director.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                        .Select(d => d.Trim())
                        .Distinct()
                        .OrderBy(d => d)
                        .ToList();
                    break;

                case "Country":
                    values = movieLibrary.GetAllMovies()
                        .Where(m => !string.IsNullOrWhiteSpace(m.Country))
                        .SelectMany(m => m.Country.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                        .Select(c => c.Trim())
                        .Distinct()
                        .OrderBy(c => c)
                        .ToList();
                    break;

                case "Main actor":
                    values = movieLibrary.GetAllMovies()
                        .Where(m => !string.IsNullOrWhiteSpace(m.MainActors))
                        .SelectMany(m => m.MainActors.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                        .Select(a => a.Trim())
                        .Distinct()
                        .OrderBy(a => a)
                        .ToList();
                    break;

                case "Duration":
                    values = new List<string>
                    {
                        "Up to 60 min",
                        "61–90 min",
                        "91–120 min",
                        "121–150 min",
                        "151+ min"
                    };
                    break;

                case "Studio":
                    values = movieLibrary.GetAllMovies()
                        .Select(m => m.Studio)
                        .Where(v => !string.IsNullOrWhiteSpace(v))
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
                    break;
            }
            cmbFilterValue.Items.AddRange(values.ToArray());
            if (cmbFilterValue.Items.Count > 0)
                cmbFilterValue.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string criterion = cmbFilterBy.SelectedItem?.ToString();
            string value = cmbFilterValue.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(criterion) || string.IsNullOrEmpty(value)) return;

            var filtered = movieLibrary.GetAllMovies().Where(m =>
            {
                return criterion switch
                {
                    "Genre" => !string.IsNullOrEmpty(m.Genre) && m.Genre.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(g => g.Trim())
                               .Contains(value),
                    "Year" => m.Year.ToString() == value,
                    "Director" => !string.IsNullOrEmpty(m.Director) && m.Director.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(d => d.Trim())
                                               .Contains(value),
                    "Country" => !string.IsNullOrEmpty(m.Country) && m.Country.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(c => c.Trim())
                                             .Contains(value),
                    "Main actor" => !string.IsNullOrEmpty(m.MainActors) && m.MainActors.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(a => a.Trim())
                                               .Contains(value),
                    "Duration" => value switch
                    {
                        "Up to 60 min" => m.Duration <= 60,
                        "61–90 min" => m.Duration > 60 && m.Duration <= 90,
                        "91–120 min" => m.Duration > 90 && m.Duration <= 120,
                        "121–150 min" => m.Duration > 120 && m.Duration <= 150,
                        "151+ min" => m.Duration > 150,
                        _ => false
                    },
                    "Studio" => m.Studio == value,
                    _ => false
                };
            }).ToList();

            if (filtered.Count == 0)
            {
                flowPanelMovies.Controls.Clear();
                Label noResults = new Label
                {
                    Text = "Фільми не знайдені",
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(10)
                };
                flowPanelMovies.Controls.Add(noResults);
            }
            else
            {
                RefreshMovieCards(filtered);
            }
        }

        private void cmbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "movies.json");
            movieLibrary.SaveToFile(filePath);
        }
    }
}
