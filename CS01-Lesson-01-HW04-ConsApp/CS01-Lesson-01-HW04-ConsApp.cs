//4. Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_01_HW04_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y1 = double.Parse(Console.ReadLine());


            double temp;
            temp = x1;
            x1 = y1;
            y1 = temp;
            Console.WriteLine("Значения после перемены: X={0}, Y={1}", x1, y1);

            x1 = x1 + y1;
            y1 = x1 - y1;
            x1 = x1 - y1;
            Console.WriteLine("Значения после перемены: X={0}, Y={1}", x1, y1);
            Console.ReadLine();
        }
    }
}
