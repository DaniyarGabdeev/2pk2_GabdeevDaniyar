using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;// индексы массива
            int[,] A = new int[4, 7];
            Console.WriteLine("Массив А: ");
            Random rnd = new Random();
            for (i = 0; i <= 3; i++)//сначала строки
            {
                for (j = 0; j <= 6; j++)//потом столбцы
                {
                    A[i, j] = rnd.Next(0, 200);//заполняется случайными числами от 0 до 199 вкл
                    Console.Write(A[i, j] + " ");//вывод значений элементов массива
                }
                Console.WriteLine();//переход на новую строку
            }
            Console.ReadLine();
        }
    }
}
