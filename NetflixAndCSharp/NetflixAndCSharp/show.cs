using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Show : Title
    {
        public List<Episode> Episodes = new List<Episode>();

        public Show()
        {
        }
        public Show(string name, int rating, Genre genre)
        {
            Name = name;
            Rating = rating;
            theGenre = genre;
        }

        public override string ToString()
        {
            return Name + ", " + Episodes.Count + " episodes";
        }

        public override int? Rating
        {
            get
            {
                int i = 0;
                foreach (var episode in  Episodes)
                {
                    rating = rating + Episodes[i].Rating;
                    i++;
                }
                return rating;
            }
            set { rating = value; }
            
        }
    }
}
