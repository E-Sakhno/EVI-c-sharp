// Задача 11. Решить задачу 10, инициализируя массив с помощью литеральных значений. Для вычисления суммы
// каждой строки использовать явные значения элементов массива. Например, b[1] = a[1,0] + a[1,1] + a[1,2] + … a[n,m],
// где b – одномерный массив для суммирования значений по каждой строке, а – двухмерный массив. Для вывода
// значений массивов воспользоваться циклом foreach
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVI11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
                new int[5,
                7]
                {
                    { 0, 1, 2, 3, 4, 5, 6 },
                    { 1, 2, 3, 4, 5, 6, 7 },
                    { 2, 3, 4, 5, 6, 7, 8 },
                    { 3, 4, 5, 6, 7, 8, 9 },
                    { 4, 5, 6, 7, 8, 9, 10 }
                };
            int[] b = new int[a.GetLength(0)];

            // for (int i = 0; i < a.GetLength(0); i++)
            // {
            //     for (int j = 0; j < a.GetLength(1); j++)
            //     {
            //         sum[i] += a[i, j];
            //     }
            // }
            b[0] = a[0, 0] + a[0, 1] + a[0, 2] + a[0, 3] +  a[0, 4] + a[0, 5] + a[0, 6];
            b[1] = a[1, 0] + a[1, 1] + a[1, 2] + a[1, 3] +  a[1, 4] + a[1, 5] + a[1, 6];
            b[2] = a[2, 1] + a[2, 1] + a[2, 2] + a[2, 3] +  a[2, 4] + a[2, 5] + a[2, 6];
            b[3] = a[3, 0] + a[3, 1] + a[3, 2] + a[3, 3] +  a[3, 4] + a[3, 5] + a[3, 6];
            b[4] = a[4, 0] + a[4, 1] + a[4, 2] + a[4, 3] +  a[4, 4] + a[4, 5] + a[4, 6];
            
            Console.WriteLine("Исходный массив: ");
            int k = 0;
            foreach (int v in a)
            {   k++;
                if (k%7 == 0){
                    Console.WriteLine("{0} ", v);
                    
                }
                else Console.Write("{0} ", v);

                

            }
            Console.WriteLine("Массив сумм: ");
            foreach (var sum in b){
                Console.Write("{0} ", sum);
            }
            
        }
    }
}
