// Задача 6. Найти разность между всеми элементами двумерного массива, которые ниже главной диагонали массива и
// элементами, которые выше. Массив ранга 2, число элементов по каждому рангу 4. Массив заполнить с помощью
// случайных чисел.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(410);
            int[,] a = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = r.Next(0, 10);
                }
            }
            int counter = 0;
            foreach (var item in a)
            {
                Console.Write("{0} ", item);
                counter++;
                if (counter % 4 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine(new string('-', 14));
            Console.Write("\nСумма элементов ниже главной диагонали матрицы: ");
            int sum_n = 0;
            int sum_v = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j >= i)
                    {
                        continue;
                    }
                    sum_n += a[i, j];
                }
            }
            Console.Write("{0}\n", sum_n);

            Console
                .Write("Сумма элементов выше главной диагонали матрицы: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j <= i)
                    {
                        continue;
                    }
                    sum_v += a[i, j];
                }
            }
            Console.Write(sum_v);
            Console.Write("\nРазность равна: {0}", sum_v-sum_n);
            
        }
    }
}
