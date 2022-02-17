using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2._3
{
    class Patient
    {
        string name;
        string fam;
        string otch;
        DateTime dataBirth;
        DateTime receiptDate;
        public string diagnoc;
        static int counter;
        static int counter1;

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
        public string Diagnoc
        {
            get { return diagnoc; }
            set { if (value == " ") diagnoc = "ошибка"; else diagnoc = value; }
        }
        public DateTime DataBirth
        {
            get { return dataBirth; }
            set { if (value > new DateTime(1940, 01, 01) && value < new DateTime(2022, 01, 01)) dataBirth = new DateTime(1000, 01, 01); }
        }
        public Patient(string name, string fam, string otch)
        {
            this.Name = name;
            this.Fam = fam;
            this.Otch = otch;
            DataBirth = new DateTime(1939, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
            diagnoc = "чума";
            if (receiptDate < new DateTime(2021, 12, 31)) counter++;
            if (dataBirth < new DateTime(1958, 01, 01)) counter1++;
        }
        public Patient(DateTime dataBirth, DateTime receiptDate)
        {
            this.DataBirth = dataBirth;
            this.receiptDate = receiptDate;
            Name = "Артем";
            Fam = "Никитин";
            Otch = "Валентинович";
            diagnoc = " ";
            if (receiptDate < new DateTime(2021, 12, 31)) counter++;
            if (dataBirth < new DateTime(1958, 01, 01)) counter1++;
        }
        public Patient(string name, string fam, string otch, string diagnos)
        {
            this.Name = Name;
            this.Fam = Fam;
            this.Otch = Otch;
            DataBirth = new DateTime(2003, 12, 12);
            receiptDate = new DateTime(2007, 02, 12);
            if (receiptDate < new DateTime(2021, 12, 31)) counter++;
            if (dataBirth < new DateTime(1958, 01, 01)) counter1++;
        }
        public static int GetCounter()
        { return counter; }
        public static int GetCounter1()
        { return counter1; }
        public virtual void GetPatientInfo()
        {
            Console.WriteLine($"Имя: {name}\nОтчество: {otch}\nФамилия: {fam}\nДата рождения: {dataBirth}\nДата поступления: {receiptDate}\nДиагноз: {diagnoc}");
        }
    }

}
