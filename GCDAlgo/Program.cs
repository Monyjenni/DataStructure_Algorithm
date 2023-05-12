using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDAlgo
{
    internal class Program
    {// function must be in internal class
        static int GCD(int a, int b)
        // static create once inside We can access static method by not instatite object from a class
        {
            int temp;
            while ((a % b) > 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Interger: ");
            //sth.Parse to cover to sth
            int FirstInterger = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Interger: ");
            //sth.Parse to cover to sth
            int SecondInterger = int.Parse(Console.ReadLine());
            //common divisor means number can divide for both number and the greatest one 
            Console.WriteLine("The Greatest Common Divisor, GCD, is: " +
                GCD(FirstInterger, SecondInterger).ToString());
            // what is console.readkey
            Console.ReadKey();
        }
    }
}
