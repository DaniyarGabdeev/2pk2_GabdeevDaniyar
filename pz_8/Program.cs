using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i <= 9; i++)//Вычесление и запсись элементов массмва
                Console.WriteLine($"{rnd.Next(0,5)}");//Вывод элементов массива
        }
    }
}
