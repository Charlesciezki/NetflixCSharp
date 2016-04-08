using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp
{
    public class Movie : Title
    {
        //-Overrides ToString() method to return a string of the name and duration of the movie
        public string Duration;

        public Movie(string name, string rating, string duration)
        {
            Name = name;
            Rating = rating;
            Duration = duration;
        }
    }
}
