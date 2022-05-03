using System;

namespace ПЗ_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int* p;
            p = &num;
            char** c;
            c = (char**)&p;
            *(*c) = '*';
            c[0][1] = '+';
            for (int k = 0; k < 2; k++)
            Console.WriteLine($"значение *: {*(*c)}");
            Console.WriteLine($"значение +: { c[0][1]}");
        }
    }
}
