// Задача 6. Написать программу для подсчета площади треугольника.
// Подсчёт площади и определение правильности треугольника сделаем в виде методов:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_06
{
    class Program
    {
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Треуголник с такими сторонами может существовать?: " + 
                IsTriangle(a,b,c));
            Console.WriteLine("Площадь треугольника: " + S(a, b, c));
            Console.ReadLine();
        }
    }
}
