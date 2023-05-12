namespace Lesson04Example
{
    class MedicalRecords
    {
        private string strPatientName;
        private float fltMedicalFees;
        public MedicalRecords(string strPatientName, float fltMedicalFees )
        {
            this.strPatientName = strPatientName;
            this.fltMedicalFees = float.MinValue;
        }
        public float CalMedicalFees()
        {
            return fltMedicalFees;
        }
        public float CalMedicalFees(string test)
        {
            if (test == "Hepatities")
            {
                fltMedicalFees = fltMedicalFees + 17.70f;
            }
            else if (test == "Cholesterol")
            {
                fltMedicalFees = fltMedicalFees + 20.00f;
            }
            return fltMedicalFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Patient's name: ");
            string Patientsname = Console.ReadLine();
            Console.WriteLine("Enter patient's medical fees: ");
            float medicalFees = float.Parse(Console.ReadLine());
            MedicalRecords mObj = new MedicalRecords(Patientsname, medicalFees);
            Console.WriteLine("Medical Fees without test is: " + mObj.CalMedicalFees().ToString());
            Console.WriteLine(("Medical Fees with Hepatities test is: " + mObj.CalMedicalFees("Hepatities ").ToString());
            Console.WriteLine(("Medical Fees with Cholesterol is: " + mObj.CalMedicalFees("Cholesterol").ToString());
        }
    }
}
