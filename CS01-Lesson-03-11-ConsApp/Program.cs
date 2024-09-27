//Задача 11.
//Структура Point

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_11_ConsApp
{
    class Program
    {
        struct Point
        {
            double _x, _y;

            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double Distance(Point z)
            {
                return Math.Sqrt(Math.Pow(_x - z._x, 2) + Math.Pow(_y - z._y, 2));
            }
        }

        static void Main(string[] args)
        {
            Point C;

            Point A = new Point(0, 0);
            Point B = new Point(2, 3);
            Console.WriteLine(A.Distance(B));

            Console.ReadLine();
        }
    }
}
