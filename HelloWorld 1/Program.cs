using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01Ex2
{
    internal class Program
    {
        class Movie
        {
            public string strTitle;
            public string strGenre;
            public int intYear;
        }
        static void Main(string[] args)
        {
            Movie objMovie1;         // part (b) delcare an object name of type movie
            objMovie1 = new Movie(); //part (c) instantiate the object objMovie1
            // Movie objMovie1 = new Movie();

            Console.Write("Enter the title of the movie:");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("What is the gnere of the move:");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("What is the year of your movie:");
            objMovie1.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Movie Title is {0}, genre is {1}, year is {2}",
                               objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear);
        }
    }
}