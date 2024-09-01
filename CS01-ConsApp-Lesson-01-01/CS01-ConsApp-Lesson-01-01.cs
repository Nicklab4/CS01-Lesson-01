// Практическая часть урока
// Задача 1. Написать программу сложения двух чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Введите первое число");
            string str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.WriteLine("Введите второе число");
            y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine(x + " + " + y + " = " + z);
            Console.ReadLine();
        }
    }
}
