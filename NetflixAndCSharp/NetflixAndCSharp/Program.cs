using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();           
            catalog.AddToTitle();
            catalog.AddEpisodes();
            catalog.GetEpisodes();
            catalog.GetMovieStats();
            catalog.AddGenres();
            catalog.genreAndTitleAdded();
            catalog.AddTitlesTogether();

            View theView = new View(catalog);
            theView.PrintOutGenres();
            catalog.displayMovies();
            Console.ReadLine();
        }
    }
}
