// Задание 5. Разработать программу, которая для заданной строки s, 
// подсчитывает количество содержащихся в ней цифр.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI5
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
                if (char.IsDigit(b[i])) // проверка, является ли символ цифрой
                {
                    x_count++;
                }
            }
            Console.WriteLine("Число цифр в строке - {0}.", x_count);
            Console.ReadLine();
        }
    }
}

