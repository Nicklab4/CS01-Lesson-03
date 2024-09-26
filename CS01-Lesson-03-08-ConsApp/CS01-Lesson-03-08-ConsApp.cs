// Задача 8. Написать программу табуляции произвольной функции в диапазоне
// от a до b.
// Написать программу табуляции произвольной функции в диапазоне от a до b.
// Функция задаётся программно.
// а) Решение без использования ООП.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_08_ConsApp
{
    class Program
    {
        static double F(double x)
        {
            return 1 / x;
        }

        static void Main(string[] args)
        {
            double a = -5;
            double b = 5;
            double h = 0.5;

            Console.WriteLine("{0,10} {1,10}", "x", "F(x)");
            for (double  x = a; x <= b; x+=h)
                Console.WriteLine("{0,10} {1,10}", x, F(x));

            Console.ReadLine();
        }
    }
}
