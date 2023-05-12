using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01Ex3
{
    internal class Program
    {
        class MedicalRecord
        {
            public string strPatientName;
            public string strDoctorName;
            public float fltFees;
        }
        static void Main(string[] args)
        {
            MedicalRecord objM1;         // part (b) delcare an object name of type medical record
            objM1 = new MedicalRecord(); //part (c) instantiate the object objM1


            Console.Write("What is the patient name:");
            objM1.strPatientName = Console.ReadLine();
            Console.Write("What is the doctor name:");
            objM1.strDoctorName = Console.ReadLine();
            Console.Write("What are the fees:");
            objM1.fltFees = float.Parse(Console.ReadLine());
            Console.WriteLine("Patient Name is {0}, doctor name is {1}, fees are {2}",
                               objM1.strPatientName, objM1.strDoctorName, objM1.fltFees);
        }
    }
}