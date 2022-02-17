using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._3
{
    internal class RecoveredPatient : Patient
    {
        public DateTime DateOfDischarge { get; set; }
        public string Result { get; set; }
        public RecoveredPatient(string name, string fam, string otch, DateTime dateOfDischarge, string result)
        : base(name, fam, otch)
        {
            DateOfDischarge = dateOfDischarge;
            Result = result;
        }
        public override void GetPatientInfo()
        {
            Console.WriteLine($"Имя: {Name}\nОтчество: {Otch}\nФамилия: {Fam}\nДата рождения: {DataBirth}\nДиагноз: {diagnoc}\nДата выписки: {DateOfDischarge}\nРезультат: {Result} ");
        }
    }
}
