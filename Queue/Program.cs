﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {   // generate an empty Queue, the cell object
            Cell TopSentinel, BottomSentinel;
            // empty constructor , do nth
            TopSentinel = new Cell();
            BottomSentinel = new Cell();
            // 
            TopSentinel.Next = BottomSentinel;
            BottomSentinel.Prev= TopSentinel;
            int x = 0;
            while (x != 5)
            {
                Console.Clear();
                Console.WriteLine("Enter 0 to display the Queue");
                Console.WriteLine("Enter 1 to EnQueue a string");
                Console.WriteLine("Enter 2 to DeQueue");

                Console.WriteLine("Enter any other number to exit.\n\n");
                x= int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Display the Queue: ");
                    for (Cell cell = TopSentinel; cell != null; cell = cell.Next)
                    {
                        Console.WriteLine(cell.Value);
                    }

                } else if (x == 1)
                {
                    Console.Write("Enter a name of the string to be enQueue onto the Queue: ");
                    string NewName = Console.ReadLine();
                    TopSentinel.enqueue(TopSentinel, NewName);

                }
                else if (x == 2)
                {
                    BottomSentinel.dequeue();

                }
                else break;
                Console.WriteLine("Press space bar to continue !");
                Console.ReadKey();
            }
        }
    }
}
