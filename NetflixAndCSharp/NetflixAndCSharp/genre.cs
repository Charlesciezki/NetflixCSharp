using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Genre
    {
        public string genre;
        public List<Title> TitleList = new List<Title>();

        public Genre(string genre)
        {
            this.genre = genre;
        }

        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre tempGenre = new Genre(genre1.genre + genre2.genre);
            tempGenre.TitleList.AddRange(genre1.TitleList);
            tempGenre.TitleList.AddRange(genre2.TitleList);
            return tempGenre;
        }

        //public static 
    }
}

