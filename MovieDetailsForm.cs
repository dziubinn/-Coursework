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
            panelDetails.Controls.Clear();
            panelDetails.BackColor = Color.OldLace;
            panelDetails.Padding = new Padding(10);

            Label lblTitle = new Label
            {
                Text = _movie.Title,
                Font = new Font("Belwe Bd BT", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
            };

            Label lblRating = new Label
            {
                Text = $"⭐ {_movie.Rating:0.0}",
                Font = new Font("Belwe Bd BT", 12, FontStyle.Bold),
                ForeColor = Color.Goldenrod,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 15)
            };

            Label lblSubtitle = new Label
            {
                Text = $"{_movie.Year} • {_movie.Duration}m • {_movie.Genre}",
                Font = new Font("Belwe Bd BT", 10),
                ForeColor = Color.Gray,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 10)
            };

            Label lblDirector = new Label
            {
                Text = $"🎬 Director: {_movie.Director}",
                Font = new Font("Belwe Bd BT", 9),
                AutoSize = true
            };

            Label lblActor = new Label
            {
                Text = $"🎭 Main Actor: {_movie.MainActors}",
                Font = new Font("Belwe Bd BT", 9),
                AutoSize = true
            };

            Label lblCountry = new Label
            {
                Text = $"🌍 Country: {_movie.Country}",
                Font = new Font("Belwe Bd BT", 9),
                AutoSize = true
            };

            Label lblStudio = new Label
            {
                Text = $"🎥 Studio: {_movie.Studio}",
                Font = new Font("Belwe Bd BT", 9),
                AutoSize = true
            };

            Label lblDescription = new Label
            {
                Text = _movie.Description,
                Font = new Font("Belwe Bd BT", 9),
                ForeColor = Color.Black,
                BackColor = Color.Wheat,
                Padding = new Padding(8),
                AutoSize = true,
                MaximumSize = new Size(panelDetails.Width - 20, 0),
                Margin = new Padding(0, 10, 0, 0)
            };

            var layout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                WrapContents = false,
                Dock = DockStyle.Top
            };

            layout.Controls.Add(lblTitle);
            layout.Controls.Add(lblSubtitle);
            layout.Controls.Add(lblRating);
            layout.Controls.Add(lblDirector);
            layout.Controls.Add(lblActor);
            layout.Controls.Add(lblCountry);
            layout.Controls.Add(lblStudio);
            layout.Controls.Add(lblDescription);

            panelDetails.Controls.Add(layout);
        }
    }
}
