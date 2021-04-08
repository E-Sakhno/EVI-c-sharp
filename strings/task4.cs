// Задание 4. Разработать программу, которая для заданной строки s,
// подсчитывает сумму всех содержащихся в ней цифр

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int digit_sum = 0;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            char[] b = s.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (char.IsDigit(b[i]))
                {
                    digit_sum += (int)Char.GetNumericValue(b[i]);
                }
            }
            Console.WriteLine("Число цифр в строке - {0}.", digit_sum);
        }
    }
}
