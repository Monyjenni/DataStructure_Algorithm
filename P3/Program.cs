using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex1
{
    class Rectangle
    {
        private float fltLength;
        private float fltBreadth;
        public float Area
        {
            get { return fltLength * fltBreadth; }
        }

        public Rectangle(float GiveMeTheLength, float GiveMeTheBreadth)
        {
            fltBreadth = GiveMeTheBreadth;
            fltLength = GiveMeTheLength;
        }
        public string GetSize()
        {
            string Toreturn = "The length and breadth of the rectangle is " + fltLength.ToString() + " and " + fltBreadth.ToString();
            return Toreturn;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1, r2;
            Console.Write("Give me the length of 1st rectangle: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Give me the breadthof 1st rectangle: ");
            float breadth = float.Parse(Console.ReadLine());
            r1 = new Rectangle(length, breadth);

            Console.Write("Give me the length of 2nt rectangle: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Give me the breadth of 2nt rectangle: ");
            breadth = float.Parse(Console.ReadLine());
            r2 = new Rectangle(length, breadth);

            Console.WriteLine("1st {0}", r1.GetSize());
            Console.WriteLine("2st{0}", r2.GetSize());
            Console.Write("Total area of the 2 rectangles is: ");
            Console.WriteLine((r1.Area + r2.Area).ToString());

        }
    }
}