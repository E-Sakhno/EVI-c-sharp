// Задача 9. Найти минимальное и максимальное число и их индексы в массиве с рангом 2. Количество элементов по
// каждому рангу равно 15. Случайные числа формируются в диапазоне от 0,0 до 1,0. Числа выводить с 4 знаками после
// запятой.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[15, 15];
            Random r = new Random(410);
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    a[i, j] = r.NextDouble();
                    Console.Write("{0:0.0000}", a[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            double min = a[0, 0];
            int minIndexI = 0;
            int minIndexJ = 0;
            double max = a[0, 0];
            int maxIndexI = 0;
            int maxIndexJ = 0;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        minIndexI = i;
                        minIndexJ = j;
                    }
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }
            }
            Console
                .WriteLine("Максимальное значение: {0:0.0000} с индексами {1} {2}",
                max,
                maxIndexI,
                maxIndexJ);
            Console
                .WriteLine("Минимальное значение: {0:0.0000} с индексами {1} {2}",
                min,
                minIndexI,
                minIndexJ);
        }
    }
}
