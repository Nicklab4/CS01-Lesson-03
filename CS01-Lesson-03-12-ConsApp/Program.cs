//Задача 12
//Класс Point

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_12_ConsApp
{
    class Point
    {
        double x, y;

        public Point()
        {
            x = y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(double value)
        {
            this.x = value;
        }

        public double GetX()
        {
            return this.x;
        }

        public double X
        {
            get { return this.x; }
            set
            {
                if (value > 0) this.x = value;
                else this.x = -value;
            }
        }

        public double Distance(Point Z)
        {
            return Math.Sqrt(Math.Pow(x - Z.x, 2) + Math.Pow(y - Z.y, 2));
        }

        public override string ToString()
        {
            return x + ", " + y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point C = new Point();
            C.SetX(10);
            Console.WriteLine(C.GetX());
            Console.WriteLine(C.X);
            C.X = 15;
            Console.WriteLine(C);

            Point A = new Point();
            Point B = new Point(2, 3);
            Console.WriteLine(A.Distance(B));

            Console.ReadLine();
        }
    }
}
