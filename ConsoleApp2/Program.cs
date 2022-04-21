using System;

namespace pz_2_009
{
    public delegate void Delegate();

    class Student
    {
    }
}
class Prepodovatili
{
    public event Delegate MyEvent;
    public void Count()
    {

        Console.WriteLine("Введите сейчас число объектов сколько хотите заполнить");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n;) 
        {
            if (n > 2.4)
            {
                Console.WriteLine("нормальная успеваемость");
                break;
            }
            else
            {
                Console.WriteLine("низкая успеваемость");
                break;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Prepodovatili visit = new Prepodovatili();
        visit.Count();
    }
}