using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Ex2
{

    class Phone
    {
        public string strModel;
        private float fltScreenSize;
       
        public float ScreenSize
        {
            get { return fltScreenSize; }
            set { if (value>0) fltScreenSize = value; }

        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            Phone pObj = new Phone();
            Console.WriteLine("Enter the type of Phone: ");
            pObj.strModel = Console.ReadLine();
            Console.WriteLine("Enter the ScreenSize: ");
            pObj.ScreenSize = float.Parse(Console.ReadLine());
            Console.WriteLine("Type = {0} and ScreenSize = {2}",
                pObj.strModel, pObj.strModel, pObj.ScreenSize);
            Console.ReadKey();
        }
    }
}