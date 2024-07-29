using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListingApp
{
    internal class User
    {
        // public logged in variable to handle logged in user
        public static string loggedInUser;
        // public dictionary of users
        public static Dictionary<string, User> userDatabase = new Dictionary<string, User>();

        public string Username { get; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Movie> Favorites { get; set; }
        public bool Admin { get; }

        // constructor
        public User(string username,
                    string password,
                    string firstName,
                    string lastName,
                    string email,
                    bool admin)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Favorites = new List<Movie>();
            Admin = admin;
        }

        // add movie to favorites
        public void AddFavoriteMovie(Movie movie)
        {
            Favorites.Add(movie);
        }
    }
}
