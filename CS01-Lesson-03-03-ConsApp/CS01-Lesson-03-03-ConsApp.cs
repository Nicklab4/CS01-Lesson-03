// Задача 3. Организовать ввод с «защитой от дурака».
// Для ввода данных с проверкой можно использовать метод TryParse.
// TryParse передаёт результат работы через параметр метода и
// возвращает информацию, правильно или неправильно произошёл
// перевод.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_03_03_ConsApp
{
    class Program
    {
        static int value;
        static string console_message = "Введите число: ";
        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
            } while (!flag);

            return x;
        }

        static void ShowValue(string description)
        {
            Console.WriteLine(description + value);
        }

        static int ReturnValue()
        {
            ShowValue("ReturnValue (до): ");
            int tmp = 10;
            ShowValue("ReturnValue (после): ");
            return tmp;
        }

        static void OutParameter(out int tmp)
        {
            ShowValue("ShowValue (до): ");
            tmp = 10;
            ShowValue("ShowValue (после): ");
        }

        static void Main(string[] args)
        {
            value = GetValue(console_message);
            Console.WriteLine("Return ... ");
            value = ReturnValue();
            ShowValue("vlaue после ReturnValue(): ");

            value = GetValue(console_message);
            Console.WriteLine("Out parameter ... ");
            OutParameter(out value);
            ShowValue("vlaue после OutParameter(): ");

            Console.ReadLine();
        }
    }
}
