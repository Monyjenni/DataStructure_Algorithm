
using System;

namespace Labo1_integer_array_reverse
{
    internal class Program
    {
        static void GenerateRandomIntegers(int[] intArray, int length)
        {// The rand() is a Lib function to generate a constant set of random Integers
           //Random is a system class, random there is just the constructor 
            Random r = new Random();

            for (int k = 0; k < length; k++)
                // next means create the next random num , %100 means the random nums only between 1 n 100
                intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 100
        }

       // will display an array 
        static void DisplayArray(int[] intArray, int length)
        {
            for (int k = 0; k < length; k++)
                Console.Write("{0}, ", intArray[k]);
            Console.WriteLine();

        }

        static void ArrayReversal(int[] intArray, int length)
        {

            // your code
            int i;
            int haftArrayLength = length / 2; 
            for (i = 0; i < haftArrayLength; i++)
            {
                int tmp = intArray[i];
                intArray[i] = intArray[length - i - 1];
                intArray[length - i - 1] = tmp;
            }

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

            //BubbleSort(intArray, length);
            ArrayReversal(intArray, length);
            Console.WriteLine("The reversed array:");
            DisplayArray(intArray, length);
            Console.ReadKey();
        }
    }
}

