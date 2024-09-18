// Задача 2. Написать функцию обмена значениями двух переменных.
// Передача параметров по ссылке — ref.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_02_ConsApp
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
