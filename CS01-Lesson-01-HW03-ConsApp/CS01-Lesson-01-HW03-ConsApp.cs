//3. а) Написать программу, которая подсчитывает расстояние
// между точками с координатами x1, y1 и x2,y2 по формуле
// r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
// Вывести результат, используя спецификатор формата .2f
// (с двумя знаками после запятой);
//
//б) *Выполнить предыдущее задание, оформив вычисления
// расстояния между точками в виде метода.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_01_HW03_ConsApp
{
    class Program
    {
        static double CoordLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние между точками: {0:F3}",
                CoordLength(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}
