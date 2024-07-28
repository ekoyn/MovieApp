using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieListingApp
{
    public enum Genre
    {
        Action,
        Adventure,
        Comedy,
        Drama,
        Romance,
        Horror,
        Thriller,
        ScienceFiction,
        Animation,
        Fantasy,
        Mystery,
        Western,
        Musical,
        Documentary,
        Biography,
        Sport,
        War,
        Historical,
        Family,
        Crime,
        Satire,
        Parody,
        Undefined
    }

    internal class Movie
    {
        public static List<Movie> movies = new List<Movie>();

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public List<double> Rating { get; set; }

        // base constructor
        public Movie()
        {
            Title = "";
            Genre = Genre.Undefined;
            Year = 0;
            Duration = "";
            Description = "";
            Rating = new List<double>();
        }

        // constructor with arguments
        public Movie(string title, 
                     Genre genre, 
                     int year, 
                     string duration, 
                     string description,
                     double rating)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Duration = duration;
            Description = description;
            Rating = new List<double>() { rating };
        }
    }
}