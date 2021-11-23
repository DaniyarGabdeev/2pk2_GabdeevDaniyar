using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader srt = new StreamReader(@"C:/Daniyar/q.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = srt.ReadLine()) != null) //читаем по одной линии(строке) пока не вычитаем все из потока (пока не достигнем конца файла)
                    {
                        i++;
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Количество строк:" + i.ToString());
                    string s = "";
                    string[] textMass;
                    StreamReader sr = new StreamReader(@"C:/Daniyar/q.txt");

                    while (sr.EndOfStream != true)
                    {
                        s += sr.ReadLine();
                    }
                    textMass = s.Split(' ');
                    Console.WriteLine("Количество слов:");
                    Console.WriteLine(textMass.Length);
                    var txt = File.ReadAllText(@"C:/Daniyar/q.txt");
                    Console.WriteLine("Количество символов:");
                    Console.WriteLine(txt.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
