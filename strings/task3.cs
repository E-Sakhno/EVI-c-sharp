// Задание 3. Разработать программу, которая для заданной строки s, подсчитывает количество букв в строке.
// Введенная строка должна содержать кроме букв, символы пунктуации и цифры.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x_count = 0;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            char[] b = s.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (char.IsLetter(b[i])) // проверка, является ли символ буквой
                {
                    x_count++;
                }
            }
            Console.WriteLine("Число букв в строке - {0}.", x_count);
            Console.ReadLine();
        }
    }
}

