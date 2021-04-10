// Задание 6. Дана строка, в которой содержится осмысленное текстовое сообщение. Слова сообщения разделяются
// пробелами и знаками препинания.
// 1. Найти самое длинное слово сообщения.
// 2. Найти самое короткое слово сообщения.
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
            string
                s,
                word_min = "",
                word_max = "",
                word = "";
            int
                max_count = 0,
                min_count = 0,
                counter = 0;

            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            char[] b = s.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if ((char.IsSeparator(b[i])) || (char.IsPunctuation(b[i]))) // если символ - пробел или знак препинания
                {
            
                    if (min_count == 0) // если слово рассматривается впервые
                    {
                        min_count = counter;
                    }

                    if ((counter < min_count) && (counter != 0))
                    {
                        word_min = word;
                        min_count = counter;
                    }

                    if (counter > max_count)
                    {
                        word_max = word;
                        max_count = counter;
                    }
                    word = "";
                    counter = 0;
                }
                if (char.IsLetter(b[i])) // если символ - буква
                {
                    counter++;
                    word += Char.ToString(b[i]); // то "собираем" слово
                }
            }
            // эта часть нужна на случай, если предложение просто закончится словом - без точки
            if ((counter < min_count) && (counter != 0))
            {
                word_min = word;
                min_count = counter;
            }

            if (counter > max_count)
            {
                word_max = word;
                max_count = counter;
            }
            Console
                .WriteLine("Самое длинное слово - {0},\nсамое короткое слово - {1}.",
                word_max,
                word_min);
            Console.ReadLine();    
        }
    }
}
