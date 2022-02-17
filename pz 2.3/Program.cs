using System;

namespace pz_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient pat = new Patient(" ", " ", "Муратович");
            Patient pat1 = new Patient(new DateTime(1937, 01, 01), new DateTime(2022, 01, 01));
            Patient pat2 = new Patient("Никита", "Адамович", "Владимирович");
            pat.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat1.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat2.GetPatientInfo();
            Console.WriteLine($"Количество пациентов поступившых вчера: {(Patient.GetCounter())}");
            Console.WriteLine($"Количество несовершенолетних пациентов: {(Patient.GetCounter1())}");
            RecoveredPatient pat3 = new RecoveredPatient("Никита", "Адамович", "Владимирович", new DateTime(2017, 02, 02), "Не выжил");
            pat3.GetPatientInfo();
        }
    }
}
