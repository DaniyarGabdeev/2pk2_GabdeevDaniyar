using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Данияр");
            Teacher teacher = new Teacher("Эльза Эдуардовна");
            stu.Notifain += teacher.reportOnProgress;
            stu.startInputRating();
        }
        
    }
    delegate void MessageAboutAcademicAchievement(string nameStdent,string educationalSubject, float mean);
    class Student
    {
        public event MessageAboutAcademicAchievement Notifain;
        string name;
        public Student(string name)
        {
            this.name = name;
        }
        public void startInputRating()
        {
            List<int> listRating = new List<int>();
            Console.WriteLine("Для остановки ввода введите все");
            Console.Write("Введите имя предмета: ");
            string nameSubject = Console.ReadLine();
            string input;
            Console.Write("Оценка: ");
            while ((input = Console.ReadLine()) != "все")
            {
                listRating.Add(int.Parse(input));
                Console.Write("Оценка: ");
            }
            float sum = 0;
            foreach(int i in listRating)
            {
                sum += i;
            }
            float mean = sum / listRating.Count;
            Notifain?.Invoke(name, nameSubject, mean);
        }
    }
    class Teacher
    {
        string name;
        public Teacher(string name)
        {
            this.name = name;
        }
        public void reportOnProgress(string nameStdent, string educationalSubject, float mean)
        {
            if(mean<=2.4)
            {
                Console.WriteLine($"{name}: у {nameStdent} по {educationalSubject} плохая успеваемость");
            }
        }
    }
}
