using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Movie : Title
    {
        public int Duration { get; set; }

        public Movie(string name, int rating, int duration, Genre genre)
            
        {
            Name = name;
            Rating = rating;
            Duration = duration;
            theGenre = genre;
        }

        public override string ToString()
        {

            return Name + ", " + Duration + " minutes";
        }
    }
}
