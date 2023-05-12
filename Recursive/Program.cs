using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial_CSharp
{
    internal class Program
    {
        static int iteractiveFactorial(int N)
        { // Iterative Function Using Loop
            int Fact = 1;
            while (N > 1)
            {
                Console.Write("{0} * ", N);
                //cout << N << " * ";
                Fact *= N--;
            }
            Console.Write("{0} ", N);
            //cout << N;
            return Fact;
        }

        static int recursiveFactorial(int N)
        { // Recursive Function
            if(N<=1)
            {
                Console.Write("1");
                return 1;
            }
            Console.Write('1');


        }

        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Enter a positive integer (maximum value 10): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 15);
            Console.WriteLine("\n");
            Console.WriteLine("\nIterative Factorial {0} = " + iteractiveFactorial(N).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("\nRecursive Factorial {0} = " + recursiveFactorial(N).ToString());
            Console.ReadKey();
        }
    }
}
