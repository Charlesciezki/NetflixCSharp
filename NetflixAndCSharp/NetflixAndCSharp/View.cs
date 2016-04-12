using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class View
    {
        public Catalog theCatalog;

        public View(Catalog catalog)
        {
            theCatalog = catalog;
        }
        public void PrintOutGenres()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Genre genresInList in theCatalog.Genres)
            {
                Console.WriteLine(genresInList.genre);
            }
        }
    }
    }

