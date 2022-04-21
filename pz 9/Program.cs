using System;
using System.Threading;

delegate void MyDelegate();
namespace PZ_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bancc chet = new Bancc(5);
            Client client = new Client(chet);

            client.slejka();
            Console.WriteLine();
            Console.WriteLine("Снять 990");
            chet.sniat(2);
            client.slejka();
            Console.WriteLine();
            Console.WriteLine("Внести 1000");
            chet.vnesti(5);
            client.slejka();
        }
    }
}