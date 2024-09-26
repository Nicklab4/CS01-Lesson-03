//Задача 4. Игра «Угадай число». Метод половинного деления.
//Написать игру «Угадай число». Компьютер загадывает число в диапазоне от 1 до 100,
//а человек за ограниченное число попыток должен угадать его. Количество попыток
//вычисляется по формуле i=log 2 N+1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_10_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;

            Random rnd = new Random();
            int guessNumber = rnd.Next(min, max);

            Console.WriteLine("Компьютер загадал число от {0} до {1}. Попробуйте его угадать за {2} попыток",
                min, max, maxCount);

            int n;
            do
            {
                count++;
                Console.WriteLine("{0} попытка. Введите число", count);
                n = int.Parse(Console.ReadLine());
                if (n > guessNumber) Console.WriteLine("Перелёт!");
                if (n < guessNumber) Console.WriteLine("Недолёт!");
            }
            while (count < maxCount && n != guessNumber);

            if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток!", count);
            else Console.WriteLine("Неудача! Попробуйте ещё раз.");

            Console.ReadLine();
        }
    }
}
