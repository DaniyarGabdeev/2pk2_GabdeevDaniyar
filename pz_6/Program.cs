using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fn;
            Console.WriteLine("Значение какого элемента ряда Фибоначчи вы хотите узнать?");
            n = Convert.ToInt32(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int f2;
            for (i = 2; i <= n; i++)
            {
                f2 = f0 + f1;
                fn = f1 * n + f2 * n;
                Console.WriteLine("Число Фибоначчи {0}", fn);
                f0++;
                f1++;
            }

            Console.ReadKey();
        }
    }
}
