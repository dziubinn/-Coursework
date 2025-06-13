using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Сoursework.Models;

namespace Сoursework
{
    /// <summary>Форма для відображення улюблених фільмів користувача.</summary>
    public partial class FavoritesForm : Form
    {
        private MovieLibrary movieLibrary;
        private List<Movie> favoriteMovies;
        private MovieCardControl selectedCard;

        /// <summary>Ініціалізує новий екземпляр форми для показу улюблених фільмів.</summary>
        public FavoritesForm(List<Movie> favoriteMovies, MovieLibrary library)
        {
            InitializeComponent();

            this.favoriteMovies = favoriteMovies;
            this.movieLibrary = library;
            this.Text = "Favorite movies";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            LoadFavoriteMovies(favoriteMovies);
        }

        /// <summary>Завантажує і відображає список улюблених фільмів на панелі з картками.</summary>
        private void LoadFavoriteMovies(List<Movie> favoriteMovies)
        {
            flowLayoutPanel.Controls.Clear();

            if (favoriteMovies.Count == 0)
            {
                labelFavorite.Text = "No favorite movies";
                return;
            }

            var favoriteTitles = favoriteMovies.Select(m => m.Title).ToList();
            foreach (var movie in favoriteMovies.ToList())
            {
                var card = new MovieCardControl();
                card.SetMovie(movie, favoriteTitles);
                card.Selected += Card_Selected;

                card.FavoriteRemoved += (s, m) =>
                {
                    m.IsFavorite = false;
                    movieLibrary.UpdateMovie(m);

                    favoriteMovies.Remove(m);
                    flowLayoutPanel.Controls.Remove((Control)s);

                    if (flowLayoutPanel.Controls.Count == 0)
                    {
                        labelFavorite.Text = "No favorite movies";
                    }
                };

                flowLayoutPanel.Controls.Add(card);
            }
        }

        /// <summary>
        /// Обробник події вибору картки фільму. Відзначає вибрану картку та знімає виділення з попередньої.
        /// </summary>
        private void Card_Selected(object sender, EventArgs e)
        {
            if (selectedCard != null)
                selectedCard.IsSelected = false;

            selectedCard = sender as MovieCardControl;

            if (selectedCard != null)
                selectedCard.IsSelected = true;
        }

        /// <summary>
        /// Обробник події натискання клавіш на формі.
        /// Закриває форму при натисканні Esc та показує деталі вибраного фільму при Ctrl+I, F1 - допомога.
        /// </summary>
        private void FavoritesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                if (selectedCard != null)
                {
                    selectedCard.ShowDetails();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("This is a form of viewing your favorite movies. \nEnter - Agree\nEsc - Refuse\nTab – Move to the next field\nShift-Tab – return to the previous field.\nInfo - Ctrl + I",
                                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
