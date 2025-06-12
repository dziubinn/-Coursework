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
    public partial class FavoritesForm : Form
    {
        private MovieLibrary movieLibrary;
        private List<Movie> favoriteMovies;
        private MovieCardControl selectedCard;
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
        private void LoadFavoriteMovies(List<Movie> favoriteMovies)
        {
            flowLayoutPanel.Controls.Clear();

            if (favoriteMovies.Count == 0)
            {
                labelFavorite.Text = "No favorite movies";
                return;
            }

            foreach (var movie in favoriteMovies.ToList())
            {
                var card = new MovieCardControl();
                card.SetMovie(movie, favoriteMovies);
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

        private void Card_Selected(object sender, EventArgs e)
        {
            if (selectedCard != null)
                selectedCard.IsSelected = false;

            selectedCard = sender as MovieCardControl;

            if (selectedCard != null)
                selectedCard.IsSelected = true;
        }

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
        }
    }
}
