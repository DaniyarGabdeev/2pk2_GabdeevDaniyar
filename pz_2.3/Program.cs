using System;

namespace pz_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient pat = new Patient(" ", "Габдеев", "Муратович");
            Patient pat1 = new Patient(new DateTime(2000, 01, 01), new DateTime(2017, 02, 02));
            Patient pat2 = new Patient("Никита", "Адамович", "Владимирович");
            pat.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat1.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat2.GetPatientInfo();
            Console.WriteLine(Patient.GetCounter());

        }
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
        static int counter;

        public string Name
        {
            get { return name; }
            set { if (value == " ") name = "ошибка"; else name = value; }
        }
        public string Fam
        {
            get { return fam; }
            set { if (value == " ") fam = "ошибка"; else fam = value; }
        }
        public string Otch
        {
            get { return otch; }
            set { if (value == " ") otch = "ошибка"; else otch = value; }
        }
        public DateTime DataBirth
        {
            get { return dataBirth; }
            set { if (value > new DateTime(1940, 01, 01) && value < new DateTime(2022, 01, 01)) dataBirth = new DateTime(1000, 01, 01); }
        }
        public Patient(string name, string fam, string otch)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            dataBirth = new DateTime(2003, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
            diagnoc = "чума";
            if (dataBirth < new DateTime(2003, 02, 15)) counter++;
        }
        public Patient(DateTime dataBirth, DateTime receiptDate)
        {
            this.dataBirth = dataBirth;
            this.receiptDate = receiptDate;
            name = "Артем";
            fam = "Никитин";
            otch = "Валентинович";
            diagnoc = "ангина";
            if (dataBirth < new DateTime(2003, 02, 15)) counter++;
        }
        public Patient(string name, string fam, string otch, string diagnos)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            dataBirth = new DateTime(2003, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
            if (dataBirth < new DateTime(2003, 02, 15)) counter++;
        }
        public static int GetCounter()
        { return counter; }
        public void GetPatientInfo()
        {
            Console.WriteLine($"Имя: {name} Отчество: {otch} Фамилия: {fam} Дата рождения: {dataBirth} Дата поступления: {receiptDate} Диагноз: {diagnoc}");
        }
    }