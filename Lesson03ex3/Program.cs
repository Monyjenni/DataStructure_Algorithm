using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03ex3
{

    class Balance
    {
        public string strType;
        private string strName;
        public string Name
        {
            get { return strName; }
            set { strName = value; }

        }
        private float fltBalance;
        public float Balance
        {
            get { return fltBalance; }
            set { fltBalance = value; }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Balance accObj = new Balance();
            Console.WriteLine("Enter the type of : ");
            accObj.strType = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            accObj.Address = Console.ReadLine();

           
            Console.WriteLine("Type = {0} and Address = {1}",
                accObj.strType, accObj.Address, accObj.Price);
        }
    }
}