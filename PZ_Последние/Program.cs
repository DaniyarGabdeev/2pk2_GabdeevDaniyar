using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace pz_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string text1 = "tele 2";
            Console.WriteLine("Предложение с tel: " + text1);
            text1 = Regex.Replace(text1, "tel|tel:", "");
            text1 = Regex.Replace(text1, "fax:|fax", "");
            Console.WriteLine("Предложение без tel: " + text1);
            Console.WriteLine("Задание 2");
            string result = "";
            string[] num3 = File.ReadAllLines("C:\\Dan\\Задание 2.txt");
            for (int i = 0; i < num3.Length; i++)
            {
                if (Regex.IsMatch(num3[i], @"[1-31]-[1-12]-\d") || Regex.IsMatch(num3[i], @"[0-23]-[0-60]") || Regex.IsMatch(num3[i], @"[0-23]:[0-60]") || Regex.IsMatch(num3[i], @"\d{1,}")) result += num3[i] + "\n";
            }
            Console.WriteLine(result);
            Console.WriteLine("Задание 3");
            string[] num4 = File.ReadAllLines("C:\\Dan\\connects.log.txt");
            for (int i = 0; i < num4.Length; i++)
            {
                string ip = "";
                string date = "";
                ip += Regex.Match(num4[i], @"\d{1,}\.\d{1,}\.\d{1,}\.\d{1,}");
                Console.WriteLine("IP:" + ip);
                date += Regex.Match(num4[i], @"29/[A-Z][a-z][a-z]/\d{4}");
                Console.WriteLine("Date:" + date);
            }
        }
    }
}