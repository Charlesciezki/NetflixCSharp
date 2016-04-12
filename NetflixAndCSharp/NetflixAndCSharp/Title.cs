using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Title
    {
        public string Name { get; set; }
        protected int? rating;
        public string title;
        public Genre theGenre;
        public virtual int? Rating
        {
            get { return rating; }
            set { rating = value; }
        }


        public Title()
        {
            Name = null;
            rating = null;
        }

        public Title(string name, int rating)
        {
            Name = name;
            this.rating = rating;

        }

        public static Genre operator +(Title title1, Title title2)
        {
            Genre tempGenre = new Genre(title1.theGenre.genre + title2.theGenre.genre);
            tempGenre.TitleList.AddRange(title1.theGenre.TitleList);
            tempGenre.TitleList.AddRange(title2.theGenre.TitleList);
            return tempGenre;
        }
    }

}
