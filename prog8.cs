// Задача 8. Найти сумму всех элементов в массиве байтов ранга 2. Количество элементов по каждому рангу равно 10.
// Использовать класс Random для формирования класса элементов массива.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] a = new byte[10, 10];
            Random r = new Random(410);
            for (byte i = 0; i < 10; i++)
            {
                for (byte j = 0; j < 10; j++)
                {
                    a[i, j] = (byte) r.Next(0, 256);
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\n");
            }

            int sum = 0;
            foreach (var b in a)
            {
                sum += b;
            }
            Console.Write("\nСумма равна: {0}", sum);
        }
    }
}
