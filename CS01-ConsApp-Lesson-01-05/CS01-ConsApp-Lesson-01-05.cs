// Практическая часть урока
// Задача 5. Работа с консолью и перегрузкой методов.
// Давайте поупражняемся с работой в консоли. Напишем для этого
// несколько функций, которые будут выводить данные в определённом
// месте консоли. А также создадим перегрузку метода, в котором
// можно будет задать цвет символов:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_ConsApp_Lesson_01_05
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            // Установка позиции курсора
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundColor)
        {
            // Установка цвета символа
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            // Вызов перегруженных функций
            Print("Привет!\n", 10, 10);
            Print("Привет ещё раз!", ConsoleColor.Red);
            Console.ReadLine();
        }
    }
}
