// Задание 5
// Класс для работы с комплексными числами.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_05_ConsApp
{
    class Complex
    {
        // Приватные поля
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать
        double re;

        // Конструктор без параметров
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор с параметрами
        // Специально создаём параметр re, который совпадает с именем поля в классе
        public Complex(double _im, double re)
        {
            im = _im;
            // Чтобы показать что к полю класса присваивается параметр,
            // используется ключевое слово this
            this.re = re;
        }

        public Complex Plus(Complex x)
        {
            Complex x2 = new Complex();
            x2.im = x.im + im;
            x2.re = x.re + re;
            return x2;
        }

        // Свойство - это механизм доступа к данным класса
        public double Im
        {
            get { return im; }
            set { if (value >= 0) im = 0; }
        }

        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1 = new Complex(1, 1);

            Complex complex2 = new Complex(2, 2);
            complex2.Im = 3;

            Complex result;
            // Так как в методе Plus создаётся новый объект,
            // в result сохраняем ссылку на вновь созданный объект
            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }
    }
}
