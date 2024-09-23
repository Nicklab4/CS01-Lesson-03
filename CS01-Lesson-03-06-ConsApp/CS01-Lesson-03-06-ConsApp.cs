//Задача 6. Найти максимальное число.
//На вход программе подаётся последовательность чисел, заканчивающаяся нулём. Найти
//максимальное число.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_06_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int max = a;

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
            }

            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
