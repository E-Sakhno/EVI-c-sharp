// Задача 10. Найти сумму элементов каждой строки двухмерного массива. Двумерный массив состоит из 7 столбцов и 5
// строк. Сумму каждой строки сохранить в одномерном массиве. Для заполнения массива использовать класс Random.
// Максимальное случайное число равно 20. Вывод результатов осуществить следующим образом. Сначала выводится
// первая строка, далее через 8 пробелов выводится ее сумма. Выводится вторая строка и через восемь пробелов ее
// сумма и т.д. Вывод должен быть подобен следующему изображению.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 7];
            int[] sum = new int[a.GetLength(1)];
            Random r = new Random(410);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(0, 21);
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum[i] += a[i, j];
                }
            }

            int k = 1;
            int count = 0;
            foreach (int v in a)
            {
                if (k++ % a.GetLength(1) == 0)
                {
                    if (v < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write (v);
                    Console.Write(new string(' ', 8));
                    Console.WriteLine(sum[count]);
                    count++;
                }
                else {
                if (v < 10)
                {
                    Console.Write(" ");
                }
                Console.Write("{0} ", v);
                }
            }
            Console.ReadLine();
        }
    }
}
