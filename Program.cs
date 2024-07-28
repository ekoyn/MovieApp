using System.Drawing.Text;

namespace MovieListingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            // Possible starting with movie list form, then calling login to avoid login form remaining open
            // Application.Run(new MovieListForm());


        }
    }
}