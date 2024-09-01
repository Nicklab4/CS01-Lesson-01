// Практическая часть урока
// Задача 3. Обменять значениями две переменные.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int t = a;
            Console.WriteLine("Первое {0} и второе {1} число ", a, b);
            a = b;
            b = t;
            Console.WriteLine("Первое {0} и второе {1} число после перестановки", a, b);
            Console.ReadLine();
        }
    }
}
