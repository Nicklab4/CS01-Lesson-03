// Задача 7. Вычислить частное q и остаток r при делении а на d, не используя
// операций деления (/) и взятия остатка от деления (%).
// Дано натуральное (целое неотрицательное) число а и целое положительное число d.
// Вычислить частное q и остаток r при делении а на d, не используя операций
// деления (/) и взятия остатка от деления (%).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_07_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int d = 3;

            int r = a, q = 0;

            while (r>=d)
            {
                r = r - d;
                q++;
            }

            Console.WriteLine("Частное {0}\nОстаток {1}", q, r);

            Console.ReadLine();
        }
    }
}
