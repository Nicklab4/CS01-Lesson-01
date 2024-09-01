//2. Ввести вес и рост человека.
//Рассчитать и вывести индекс массы тела (ИМТ) по формуле
//I = m /(h*h); где m — масса тела в килограммах, h — рост в метрах.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_01_HW02_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine("Задайте ваш рост в метрах");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Задайте ваш вес в килограммах");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш ИМТ (индекс массы тела): " + (weight / (height * height)));
            Console.ReadLine();
        }
    }
}
