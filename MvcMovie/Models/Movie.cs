using System.ComponentModel.DataAnnotations;

// This file defines the Movie model, which is what goes into the database.

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        // The ? means that this variable is nullable.
        public string? Title { get; set; }

        // This attribute below makes it so that the user isn't required to enter time information in the date field, 
        // and also the time is not displayed.
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    
    }
}
