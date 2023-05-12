using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Q1
{
    internal class Program
    {
        static void GenerateRandomIntegers(int[] intArray, int length)
        {// The rand() is a Lib function to generate a constant set of random Integers
            Random r = new Random();
            for (int k = 0; k < length; k++)
                intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 100
        }

        static void DisplayArray(int[] intArray, int length)
        {
            for (int k = 0; k < length; k++)
                Console.Write("{0}, ", intArray[k]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[15];
            int length;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);

            // Your code goes here, find the sum of all odd-index integers in the array:
            int sum = 0;
            
            // index starts from 0 
            int index = 0;
            // if the index is less than the lenght(the total amount entered num)
            while( index < length) //1
            {
                //length = 5
                //1 : index  = 0
                // if the remainder is not eqaul to 0
                if ((index % 2) != 0)
                {
                    //2 : inex = 1 
                    // 0 = 0 + 70 => sum = 70
                    //intArray[index] means the value of that index
                    sum = sum + intArray[index];
                }
                index++;
            }
            Console.WriteLine("The sum of integer @ odd index position is {0}",sum);

            Console.ReadKey();


        }
    }
}
