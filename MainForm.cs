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
    public partial class MainForm : Form
    {
        private MovieLibrary movieLibrary = new MovieLibrary();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            movieLibrary.LoadFromFile("movies.json");
            cmbFilterBy.Items.AddRange(new string[]
            {
                "Genre",
                "Year",
                "Director",
                "Country",
                "Main actor",
                "Duration",
                "Studio"
            });
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
                        .Select(m => m.Genre)
                        .Where(v => !string.IsNullOrWhiteSpace(v))
                        .Distinct()
                        .OrderBy(v => v)
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
                        .Select(m => m.Director)
                        .Where(v => !string.IsNullOrWhiteSpace(v))
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
                    break;

                case "Country":
                    values = movieLibrary.GetAllMovies()
                        .Select(m => m.Country)
                        .Where(v => !string.IsNullOrWhiteSpace(v))
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
                    break;

                case "Main actor":
                    values = movieLibrary.GetAllMovies()
                        .Select(m => m.MainActors)
                        .Where(v => !string.IsNullOrWhiteSpace(v))
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
                    break;

                case "Duration":
                    values = movieLibrary.GetAllMovies()
                        .Select(m => m.Duration.ToString())
                        .Distinct()
                        .OrderBy(v => v)
                        .ToList();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            movieLibrary.LoadFromFile("movies.json");
            MessageBox.Show("Data is loaded.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            movieLibrary.SaveToFile("movies.json");
            MessageBox.Show("Data is saved");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
                    "Genre" => m.Genre == value,
                    "Year" => m.Year.ToString() == value,
                    "Director" => m.Director == value,
                    "Country" => m.Country == value,
                    "Main actor" => m.MainActors == value,
                    "Duration" => m.Duration.ToString() == value,
                    "Studio" => m.Studio == value,
                };
            }).ToList();

            MessageBox.Show($"Found {filtered.Count} movies by filter");
        }
    }
}
