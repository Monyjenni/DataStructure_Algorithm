using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class TVBrand
    {
        public string strBrandName;
        private float fltPrice;
        public float Pice
        {
            get { return fltPrice; }
        }

        static public float fltTotalPrice = 0.0f;
        public TVBrand(string strBrandName, float fltPrice)
        {
           
            this.strBrandName = strBrandName;
            this.fltPrice = fltPrice;
            fltTotalPrice += fltPrice;
        }
        public string GetTotalInfo()
        {
            return (strBrandName );
        }
    }

    class Type : TVBrand
    {
        private string strType;
        public Type(string strBrandName, float fltPrice, string strType)
          : base(strBrandName,float fltPrice)
        {
            this.strType = strType;
            fltTotalPrice++;
        }
        public string GetInfo()
        {
            return ("TV type: " + strType + ", Brand name: " + strBrandName
                + ", Price: " + fltTotalPrice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type objS1, objS2;
            Console.Write("Enter TV brand #1: ");
            string BrandName = Console.ReadLine();
            Console.Write("Enter type of TV #1: ");
            string Type = Console.ReadLine();
            Console.Write("Enter price of TV #1: ");
            String Price = Console.ReadLine();
           
            Console.Write("Enter TV brand #2: ");
            BrandName = Console.ReadLine();
            Console.Write("Enter type of TV #2: ");
            Type = Console.ReadLine();
            Console.Write("Enter price of TV #2: ");
            Price = Console.ReadLine();

            objS1 = new Type(BrandName, Type, Price);
            Console.WriteLine("objS1: {0}", objS1.GetInfo());
            Console.WriteLine("");

            objS2 = new Type(BrandName, Type, Price);
            Console.WriteLine("objS2: {0}", objS2.GetInfo());
            Console.WriteLine("");

            Console.WriteLine("Total number of Price: {0}", TVBrand.GetTotalInfo());
        }
    }
}