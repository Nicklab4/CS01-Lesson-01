// Практическая часть урока
// Задача 4. Разработать метод проверки чётности числа.
// Метод возвращает true - если число чётное,
// и false - если число нечётное.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100501;
            Console.WriteLine(Odd(value));
            Console.ReadLine();
        }

        static bool Odd(int n)
        {
            return n % 2 == 0;
        }
    }
}
