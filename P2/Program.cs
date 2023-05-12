using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Accessor

namespace Lesson02Ex1
{
    class Employee
    {
        public string strName;
        private float fltSalary;
        public float Salary
        {
            get { return fltSalary; }
            set { if (value > 0) fltSalary = value; } //the price are add when value >0
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee empObj = new Employee();
                Console.Write("Enter the name: ");
                empObj.strName = Console.ReadLine();

                Console.Write("Enter the salary: ");
                empObj.Salary = float.Parse(Console.ReadLine());

                Console.WriteLine("Name: {0}, Salary: {1}", empObj.strName, empObj.Salary);

            }
        }
    }
}