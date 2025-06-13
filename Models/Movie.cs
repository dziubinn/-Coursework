using System;

namespace Сoursework.Models
{
    /// <summary>
    /// Клас, що описує фільм у медіатеці. Містить основні властивості.
    /// </summary>
    public class Movie
    {
        /// <summary>Унікальний ідентифікатор фільму.</summary>
        public string Id { get; set; }

        /// <summary>Назва фільму.</summary>
        public string Title { get; set; }

        /// <summary>Студія, що виробила фільм.</summary>
        public string Studio { get; set; }

        /// <summary>Жанр фільму (може містити кілька жанрів, розділених комами або крапками з комою).</summary>
        public string Genre { get; set; }

        /// <summary>Рік випуску фільму.</summary>
        public int Year { get; set; }

        /// <summary>Країна виробництва фільму.</summary>
        public string Country { get; set; }

        /// <summary>Імена режисерів (може містити кілька імен, розділених комами або крапками з комою).</summary>
        public string Director { get; set; }

        /// <summary>Імена головних акторів (може містити кілька імен, розділених комами або крапками з комою).</summary>
        public string MainActors { get; set; }

        /// <summary>Опис сюжету фільму.</summary>
        public string Description { get; set; }

        /// <summary>Рейтинг фільму (числове значення від 0 до 10).</summary>
        public double Rating { get; set; }

        /// <summary>Тривалість фільму у хвилинах.</summary>
        public int Duration { get; set; }

        /// <summary>Прапорець, чи доданий фільм у список улюблених.</summary>
        public bool IsFavorite { get; set; }
    }
}
