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
    public partial class FavoritesForm: Form
    {
        private List<Movie> favoriteMovies;
        public FavoritesForm(List<Movie> favoriteMovies)
        {
            InitializeComponent();
            this.Text = "Favorite movies";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.favoriteMovies = favoriteMovies;

            LoadFavoriteMovies(favoriteMovies);
        }
        private void LoadFavoriteMovies(List<Movie> favoriteMovies)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var movie in favoriteMovies.ToList())
            {
                var card = new MovieCardControl();
                card.SetMovie(movie, favoriteMovies);

                card.FavoriteRemoved += (s, m) =>
                {
                    favoriteMovies.Remove(m);
                    flowLayoutPanel.Controls.Remove((Control)s);
                };

                flowLayoutPanel.Controls.Add(card);
            }
        }
    }
}
