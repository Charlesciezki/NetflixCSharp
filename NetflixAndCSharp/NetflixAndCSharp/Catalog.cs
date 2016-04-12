using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace NetflixAndCSharp
{
    public class Catalog
    {
        
        public List<Genre> Genres = new List<Genre> ();
        public Genre Comedy = new Genre("Comedy");
        public Genre Action = new Genre("Action");
        public Genre Romantic = new Genre("Romantic");
        public Show SouthPark;
        Genre genre;


        public Movie StepBrothers;

        public Catalog()
        {
            Genres.Add(Comedy);
            Genres.Add(Action);
            Genres.Add(Romantic);
            SouthPark = new Show("South Park", 5, Comedy);
            StepBrothers = new Movie("Step Brothers", 5, 90, Comedy);
    }

        public void AddGenres()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Genre genre1;
            Genre genre2;
            Console.WriteLine("Welcome to the Genre splicer! We add genres together so you can view all the titles!");
            Console.WriteLine("Select your first genre: 1: Comedy 2: Romance 3: Action");
            genre1 = genreSelector();
            Console.WriteLine("Select your second genre: 1: Comedy 2: Romance 3: Action");
            genre2 = genreSelector();
            Genre newGenre = genre1 + genre2;
            
            foreach (Title title in newGenre.TitleList)
            {
                Console.WriteLine(title.Name);
                
            }

        }

        public Genre genreSelector()
        {
            Console.WriteLine("1: Comedy 2: Romance 3: Action");
            int genreselect = Convert.ToInt32(Console.ReadLine());
            switch (genreselect)
            {
                case 1:
                    genre = Comedy;
                    break;
                case 2:
                    genre = Romantic;
                    break;
                case 3:
                    genre = Action;
                    break;
                default:
                    AddGenres();
                    break;
            }
            return genre;
        }

        public void AddTitlesTogether()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's add titles!");         
            Title title1 = titleSelector();
            Console.WriteLine("Let's add another title!");
            Title title2 = titleSelector();
            Genre newTitle = title1 + title2;
            foreach (Title title in newTitle.TitleList)
            {
                Console.WriteLine(title.Name);
            }

        }

        public void genreAndTitleAdded()
        {
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Select a genre");
            Genre genre = genreSelector();
            Title title = titleSelector();
            foreach (Title genreTitle in genre.TitleList)
            {
                Console.WriteLine(genreTitle);
            }
            Console.WriteLine(title);
        }

        public Title titleSelector()
        {
            Console.WriteLine("Please select a title by the number next to it");
            Genre allGenres =Comedy + Romantic + Action;
            int i = 0;
            foreach (Title title in allGenres.TitleList)
            {
                Console.WriteLine(i + " " + title.Name);
                i++;
            }
            int titleChoice = Convert.ToInt32(Console.ReadLine());
            return allGenres.TitleList[titleChoice];

        }
        public void AddToTitle()
        {
            Comedy.TitleList.Add(StepBrothers);
            Comedy.TitleList.Add(SouthPark);
            Comedy.TitleList.Add(new Movie("Dodge Ball", 4, 100, Comedy));
            
            Action.TitleList.Add(new Movie("Die Hard", 4, 90, Action));
            Action.TitleList.Add(new Movie("The Transporter", 4, 90, Action));
            Action.TitleList.Add(new Show("Gotham", 4, Action));

            Romantic.TitleList.Add(new Movie("The Notebook", 1, 120, Romantic));
            Romantic.TitleList.Add(new Movie("Titanic", 2, 220, Romantic));
            Romantic.TitleList.Add(new Show("Friends", 1, Romantic));
        }

        public void AddEpisodes()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
            Thread.Sleep(10);
            int theRating = random.Next(1, 6);
            SouthPark.Episodes.Add(new Episode(theRating));
            }

        }

        public void AddShow()
        {
            int genreChoice;
            string showName;
            int showRating;
            Console.WriteLine("What genre would you like to add to?");
            Console.WriteLine("1: Comedy 2: Romance 3: Action");
            genreChoice = Convert.ToInt32(Console.ReadLine());
            switch (genreChoice)
            {
                case 1:
                    Console.WriteLine("Enter the name of the comedy show");
                    showName = Console.ReadLine();
                    Console.WriteLine("Enter rating of the show");
                    showRating = Convert.ToInt32(Console.ReadLine());
                    Comedy.TitleList.Add(new Show(showName, showRating, Comedy));
                    break;

                case 2:
                    Console.WriteLine("Enter the name of the romantic show");
                    showName = Console.ReadLine();
                    Console.WriteLine("Enter rating of the show");
                    showRating = Convert.ToInt32(Console.ReadLine());
                    Romantic.TitleList.Add(new Show(showName, showRating, Romantic));
                    break;

                case 3:
                    Console.WriteLine("Enter the name of the action show");
                    showName = Console.ReadLine();
                    Console.WriteLine("Enter rating of the show");
                    showRating = Convert.ToInt32(Console.ReadLine());
                    Action.TitleList.Add(new Show(showName, showRating, Action));
                    break;

                default:
                    AddShow();
                    break;
            }
        }

        public void GetEpisodes()
        {
            Console.WriteLine(SouthPark.ToString());
            Console.WriteLine("Average South Park Rating is " + SouthPark.Rating);            
        }

        public void GetMovieStats()
        {
            Console.WriteLine(StepBrothers.ToString());
            
        }
               
        public void displayMovies()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Comedy:");
            for (int i = 0; i < Comedy.TitleList.Count; i++)
            {
                    Console.WriteLine(Comedy.TitleList[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Romantic:");
            for (int i = 0; i < Romantic.TitleList.Count; i++)
            {
                Console.WriteLine(Romantic.TitleList[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Action:");
            for (int i = 0; i < Action.TitleList.Count; i++)
            {
                Console.WriteLine(Action.TitleList[i].Name);
            }
        }
        
    }
}
