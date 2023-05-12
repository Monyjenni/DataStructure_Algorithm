using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex1
{
    class Balance
    {
        private string strType;
        private string strName;
        private float fltBalance;
        public float Area   //part (b)
        {   //a read only property is an accessor that 
            //only has a get accessor
            get { return fltBalance; }
        }
        //constructor add 1 parameter
        public Balance(string x, float Balance,string y)
        {
            strType = x;
            fltBalance = Balance;
            strName = y;
        }
        public string CalInterest()
        {
            string ToReturn;
            ToReturn = "The interest is"+ fltBalance*0.018;
            return ToReturn;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Balance r1, r2;   //declaration - part (e)
            Console.Write("Give me the length for 1st rectangle obj please: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Give me the breadth for 1st rectangle obj please: ");
            float breadth = float.Parse(Console.ReadLine());
            r1 = new Balance(length, breadth);

            Console.Write("Give me the length for 2nd rectangle obj please: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Give me the breadth for 2nd rectangle obj please: ");
            breadth = float.Parse(Console.ReadLine());
            r2 = new Balance (length, breadth);

            Console.WriteLine("r1: " + r1.Balance());
            Console.WriteLine("r2: " + r2.Balance());
            Console.Write("Total area of the 2 rectagles is: ");
            Console.WriteLine((r1.Area + r2.Area).ToString());
        }
    }
}