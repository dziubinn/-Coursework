using System;

namespace Сoursework.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string MainActors { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int Duration { get; set; }
        public bool Watched { get; set; }
        public bool IsFavorite { get; set; }
    }
}
