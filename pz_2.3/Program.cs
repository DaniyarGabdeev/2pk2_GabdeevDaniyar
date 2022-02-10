using System;
namespace pz_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient pat = new Patient("Данияр","Габдеев","Муратович");
            Patient pat1 = new Patient(new DateTime(2000, 01, 01), new DateTime(2017, 02, 02));
            Patient pat2 = new Patient("Никита","Адамович","Владимирович");
            pat.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat1.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat2.GetPatientInfo();

        }
    }
    class Patient
    {
        string name;
        string fam;
        string otch;
        DateTime dataBirth;
        DateTime receiptDate;
        string diagnoc;

        public Patient(string name, string fam, string otch)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            dataBirth = new DateTime(2003, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
            diagnoc = "чума";
        }
        public Patient(DateTime dataBirth, DateTime receiptDate)
        {
            this.dataBirth = dataBirth;
            this.receiptDate = receiptDate;
            name = "Артем";
            fam = "Никитин";
            otch = "Валентинович";
            diagnoc = "ангина";
        }
        public Patient(string name, string fam, string otch, string diagnos)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            dataBirth = new DateTime(2003, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
        }
        public void GetPatientInfo()
        {
            Console.WriteLine($"Имя: {name} Отчество: {otch} Фамилия: {fam} Дата рождения: {dataBirth} Дата поступления: {receiptDate} Диагноз: {diagnoc}");
        }
    }

}