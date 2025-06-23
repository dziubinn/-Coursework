 using Microsoft.VisualBasic.Logging;
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
using System.IO;

namespace Сoursework
{
    /// <summary>
    /// Головна форма застосунку "Фільмотека".
    /// Забезпечує графічний інтерфейс користувача для перегляду, пошуку, фільтрації, додавання, редагування та видалення фільмів, а також перегляду улюблених.
    /// </summary>
    public partial class UserForm : Form
    {
        private MovieLibrary movieLibrary = new MovieLibrary();
        private List<Movie> movies = new List<Movie>();
        private MovieCardControl selectedCard;
        private string userLogin;

        /// <summary>
        /// Конструктор головної форми програми.
        /// Ініціалізує компоненти форми та підписується на події завантаження форми і натискання кнопки відкриття обраного.
        /// </summary>
        public UserForm(string login)
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            btnOpenFavorites.Click += btnOpenFavorites_Click;
            userLogin = login;
            welcomeLabel.Text = $"Welcome, {userLogin}!";
        }

        /// <summary>
        /// Обробник події завантаження головної форми.
        /// Завантажує фільми з файлу, ініціалізує списки, налаштовує обробку клавіш та заповнює комбобокс фільтрації.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "movies.json");
            movieLibrary.LoadFromFile(filePath);
            movies = movieLibrary.GetAllMovies();

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            cmbFilterBy.Items.Clear();
            cmbFilterBy.Items.AddRange(new string[]
            {
                "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio"
            });

            RefreshMovieCards();
        }

        /// <summary>
        /// Обробник події закриття головної форми.
        /// Зберігає поточну бібліотеку фільмів у файл перед завершенням роботи.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "movies.json");
            movieLibrary.SaveToFile(filePath);
            var favorites = FavoritesManager.LoadFavorites(userLogin);
            FavoritesManager.SaveFavorites(userLogin, favorites);
        }

        /// <summary>
        /// Обробник події натискання клавіш на головній формі.
        /// Реалізує гарячі клавіші для пошуку, фільтрації, виходу, відкриття довідки та керування фільмами.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == txtSearch)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    btnSearch.PerformClick();
                }
                else if (ActiveControl == cmbFilterValue)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    btnFilter.PerformClick();
                }
            }

            else if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("This form is the main part of the application. It provides the user with a convenient interface for viewing, searching, filtering, and managing movies in the media library." +
                    "\nEnter - Agree" +
                    "\nEsc - Refuse" +
                    "\nTab – Move to the next field" +
                    "\nShift-Tab – return to the previous field" +
                    "\nInfo - Ctrl + I",
                                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (e.Control && e.KeyCode == Keys.I)
            {
                if (selectedCard != null)
                {
                    selectedCard.ShowDetails();
                }
                e.Handled = true;
            }
        }

        /// <summary>
        /// Оновлює відображення карток фільмів на формі.
        /// Можна передати список фільмів для відображення, або за замовчуванням будуть використані всі фільми з бібліотеки.
        /// </summary>
        private void RefreshMovieCards(List<Movie> moviesToDisplay = null)
        {
            flowPanelMovies.Controls.Clear();

            var movies = moviesToDisplay ?? movieLibrary.GetAllMovies();
            var currentFavorites = FavoritesManager.LoadFavorites(userLogin);

            foreach (var movie in movies)
            {
                var card = new MovieCardControl();
                card.SetMovie(movie, currentFavorites);
                card.FavoriteAdded += (s, m) =>
                {
                    FavoritesManager.AddFavorite(userLogin, m.Title);
                };

                card.FavoriteRemoved += (s, m) =>
                {
                    FavoritesManager.RemoveFavorites(userLogin, m.Title);
                };

                card.Selected += MovieCardControl_Selected;
                flowPanelMovies.Controls.Add(card);
            }
        }

        /// <summary>
        /// Обробник події вибору картки фільму.
        /// Знімає виділення з усіх інших карток та встановлює вибраною лише ту, яку було натиснуто.
        /// </summary>
        private void MovieCardControl_Selected(object sender, EventArgs e)
        {
            foreach (var otherCard in flowPanelMovies.Controls.OfType<MovieCardControl>())
                otherCard.IsSelected = false;

            if (sender is MovieCardControl card)
            {
                card.IsSelected = true;
                selectedCard = card;
            }
        }

        /// <summary>
        /// Обробник події вибору картки фільму.
        /// Зберігає посилання на вибрану картку для подальших операцій (наприклад, редагування або перегляду деталей).
        /// </summary>
        private void OnCardSelected(object sender, EventArgs e)
        {
            selectedCard = (MovieCardControl)sender;
        }

        /// <summary>
        /// Обробник події натискання кнопки "Відкрити улюблені фільми".
        /// Відкриває окрему форму для перегляду улюблених фільмів. Якщо улюблених фільмів немає, повідомляє користувача.
        /// </summary>
        private void btnOpenFavorites_Click(object sender, EventArgs e)
        {
            var favoriteTitles = FavoritesManager.LoadFavorites(userLogin);
            var allMovies = movieLibrary.GetAllMovies();
            var favoriteMovies = allMovies
                .Where(m => favoriteTitles.Contains(m.Title))
                .ToList();

            if (favoriteMovies.Count == 0)
            {
                MessageBox.Show("You have no favorite movies selected.", "Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var favForm = new FavoritesForm(favoriteMovies, movieLibrary);
            favForm.ShowDialog();
            movies = movieLibrary.GetAllMovies();

            RefreshMovieCards();
        }

        /// <summary>
        /// Обробник натискання кнопки "Home".
        /// Скидає фільтри та пошук, відображає всі фільми.
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "All Movies";
            RefreshMovieCards(movies);
            return;
        }

        /// <summary>
        /// Обробник події натискання кнопки "Пошук".
        /// Виконує пошук фільмів за назвою за текстом у полі пошуку.
        /// Оновлює відображення карток відповідно до результатів пошуку.
        /// Якщо рядок пошуку порожній — показує всі фільми.
        /// Якщо фільмів за пошуком немає — відображає відповідне повідомлення.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                lblHeader.Text = "All Movies";
                RefreshMovieCards(movies);
                return;
            }

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

            lblHeader.Text = $"Search Results for \"{txtSearch.Text.Trim()}\"";
        }

        /// <summary>
        /// Обробник події зміни вибору критерію фільтрації у комбобоксі.
        /// Заповнює комбобокс значеннями для фільтрації відповідно до вибраного критерію.
        /// </summary>
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

        /// <summary>
        /// Обробник події натискання кнопки "Фільтрувати".
        /// Фільтрує список фільмів за вибраним критерієм та значенням, оновлює відображення фільмів відповідно до результатів.
        /// Якщо фільмів, що відповідають фільтру, немає - показує відповідне повідомлення.
        /// </summary>
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
                    Text = "No movies found.",
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

            lblHeader.Text = $"Filtered by {criterion}: \n{value}";
        }
    }
}
