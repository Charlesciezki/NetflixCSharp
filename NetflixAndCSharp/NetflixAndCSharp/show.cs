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
        //-Overrides parent’s Rating to return an aggregated rating of Episode ratings 
        //-Overrides ToString() method to return a string of the name of the show and number of episodes
        //public string Name;
        //public string Rating;
        List<string> Episodes = new List<string>();

        public Show(string name, string rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}
