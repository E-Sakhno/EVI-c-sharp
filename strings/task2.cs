// Задание 2. Разработать программу, которая для заданной строки s, подсчитывает общее число вхождений символов х и y.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char x, y;
            int
                x_count = 0,
                y_count = 0;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            Console.WriteLine("Введите x: ");
            x = Console.ReadLine().ToCharArray()[0]; // преобразование string в char
            Console.WriteLine("Введите y: ");
            y = Console.ReadLine().ToCharArray()[0];
            char[] b = s.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (char.ToLower(b[i]) == char.ToLower(x)) // преобразование к нижнему регистру
                {
                    x_count++;
                }
                else if (char.ToLower(b[i]) == char.ToLower(y))
                {
                    y_count++;
                }
            }
            Console.WriteLine("Число вхождений символа {0} - {1},\nчисло вхождений символа {2} - {3}.",
                x, x_count, y, y_count);
            Console.ReadLine();    
        }
    }
}
