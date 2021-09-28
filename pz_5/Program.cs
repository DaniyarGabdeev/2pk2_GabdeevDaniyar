using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Console.WriteLine("Задание 1\n");
            int a = 20;
            int b = 100;


            for (int i = a; i <= b; i += 4)
            {
                Console.WriteLine(i);
            }
            //Второе задание
            Console.WriteLine("Задание 2\n");

            char gaga = 'f';
            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine(gaga);
                gaga++;
            }
            //Третье задание
            Console.WriteLine("Задание 3\n");
            var j1 = '#';
            for (int i = 0; i != 6; i++)
            {
                for (int i0 = 0; i0 != 4; i0++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine();
            }
            //Четверое задание
            Console.WriteLine("Задание 4\n");
            for (int i = 1; i != 100; i++)
            {
                var david = i % 11;
                if (david == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Пятое задание
            Console.WriteLine("Задание 5\n");

            for (int i = 2, j = 40; i - j != 20; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
