using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixAndCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAndCSharp.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Movie SuperBad = new Movie("SuperBad", 5, 90, new Genre("Comedy"));
            string response = SuperBad.ToString();
            Assert.AreEqual("SuperBad, 90 minutes", response);
            
        }
        [TestMethod()]
        public void AddShowTest()
        {
            Show RickAndMorty = new Show("Rick And Morty", 5, new Genre("Comedy"));
            RickAndMorty.Episodes.Add(new Episode(5));
            string response = RickAndMorty.ToString();
            Assert.AreEqual("Rick And Morty, 1 episodes", response);
        }
        [TestMethod()]
        public void AddEpisodeTest()
        {
            
        }
        [TestMethod()]
        public void tringTest()
        {
            
        }
        [TestMethod()]
        public void ringTest()
        {
            
        }
    }
}