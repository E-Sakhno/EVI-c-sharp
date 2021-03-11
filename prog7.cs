// Задача 7. Программу из задачи 1 лабораторной переписать для использования массива с числами двойной точности с
// плавающей точкой.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[15];
            Random r = new Random(410);
            for (int i = 0; i < 15; i++)
            {
                a[i] = r.NextDouble();

                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
