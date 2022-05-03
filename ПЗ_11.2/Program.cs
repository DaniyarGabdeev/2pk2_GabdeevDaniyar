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
            Console.WriteLine($"значение *: {*(*c)}");
            Console.WriteLine($"значение +: { c[0][1]}");
        }
    }
}
