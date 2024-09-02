//5. а) Написать программу, которая выводит на экран ваше имя,
// фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов
// (например, Print(string ms, int x,int y).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_01_HW05_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine("Назовите ваше Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Назовите вашу Фамилию:");
            string lastname  = Console.ReadLine();
            Console.WriteLine("Назовите ваш город:");
            string town = Console.ReadLine();
            string finalS = name + " "+ lastname + " живёт в городе " + town;

            Cn.Print(finalS, (Console.BufferWidth - finalS.Length) / 2,
                Console.CursorTop + 1);

            Console.ReadLine();
        }
    }

    static class Cn
    {
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

    }
}
