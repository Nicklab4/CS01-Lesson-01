//1. Написать программу «Анкета». Последовательно задаются вопросы
//(имя, фамилия, возраст,рост, вес). В результате вся информация
//выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine("Назовите ваше Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Назовите вашу Фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Назовите ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Назовите ваш рост:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Назовите ваш вес:");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваши данные:");
            Console.WriteLine("Склеивание: " +
                "Имя: " + name + ", Фамилия: " + lastName +
                ", Возраст: " + age + ", Рост: " + height +", Вес: "+ weight);
            Console.WriteLine("Форматированный вывод: Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}",
                name, lastName, age, height, weight);
            // Символ $ определяет строковый литерал как интерполированную строку.
            // Появился в версии C#-6 или .NET Framework 4.6, VS 2015
            //Console.WriteLine($"Имя: {name}, Фамилия: {lastName}, Возраст: {age}, Рост: {height}, Вес: {weight}");

            Console.ReadLine();
        }
    }
}
