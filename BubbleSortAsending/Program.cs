﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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

        public static void BubbleSortAscendingImproved(int[] input, int length)
        {
            int temp;
                for (int i=0; i < (length - 1); i++)
                {
                    for (int j = 0 ; j < (length - 1 - i); j++)
                    {
                        if (input[j] > input[j+1])
                        {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;

                        }
                    }
                }


        }
        public static void BubbleSortDesending(int[] input, int length)
        {
            int temp;
            for (int i = 0; i < (length - 1); i++)
            {
                for (int j = 0; j < (length - 1 - i); j++)
                {
                    if (input[j] < input[j + 1])
                    {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;

                    }
                }
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
            BubbleSortAscendingImproved(intArray, length);
            Console.WriteLine("The sorted array(Ascending:");
            DisplayArray(intArray, length);

            Console.WriteLine("------------------------------------------------------------");

            //BubbleDescendingSort(intArray, length);
            BubbleSortDesending(intArray, length);
            Console.WriteLine("The sorted array(Desending):");
            DisplayArray(intArray, length);


            Console.ReadKey();
        }



    }

}
