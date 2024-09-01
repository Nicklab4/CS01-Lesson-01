// Практическая часть урока
// Задача 2. Вывести значение функции ax^2+bx+c в точке x. x — ввести с
// клавиатуры, a,b и c — присвоить в программе.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 1;
            double c = 1;
            Console.WriteLine("Введите значение X");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double f = a * Math.Pow(x, 2) + b * x + c;
            Console.WriteLine("{0}*x^2 + {1}*x + {2}, при x={3}, f={4}", a, b, c, x, f);
            Console.ReadLine();
        }
    }
}
