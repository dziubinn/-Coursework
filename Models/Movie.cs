using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сoursework.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string MainActors { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public bool Watched { get; set; }
        public bool IsFavorite { get; set; }

    }
}
