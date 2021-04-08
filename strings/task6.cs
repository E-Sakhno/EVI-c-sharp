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
                if (
                    (char.IsSeparator(b[i])) ||
                    (char.IsPunctuation(b[i]))
                )
                {
                    Console.WriteLine (word);
                    if (min_count == 0)
                    {
                        Console.WriteLine("min before - {0}", min_count);
                        min_count = counter;
                        Console.WriteLine("min after - {0}", min_count);
                    }

                    if ((counter < min_count) && (counter != 0))
                    {
                        Console.WriteLine("min before - {0}", word_min);
                        word_min = word;
                        min_count = counter;
                        Console.WriteLine("min after - {0}", word_min);
                    }

                    if (counter > max_count)
                    {
                        Console.WriteLine("max berofe - {0} - ", word_max);
                        word_max = word;
                        max_count = counter;
                        Console.WriteLine("max after - {0} - ", word_max);
                    }
                    word = "";
                    counter = 0;
                }
                if (char.IsLetter(b[i]))
                {
                    // Console.WriteLine (counter);
                    // Console.WriteLine (word);
                    counter++;
                    word += Char.ToString(b[i]);
                }
            }
            if ((counter < min_count) && (counter != 0))
                    {
                        Console.WriteLine("min before - {0}", word_min);
                        word_min = word;
                        min_count = counter;
                        Console.WriteLine("min after - {0}", word_min);
                    }

                    if (counter > max_count)
                    {
                        Console.WriteLine("max berofe - {0} - ", word_max);
                        word_max = word;
                        max_count = counter;
                        Console.WriteLine("max after - {0} - ", word_max);
                    }
            Console
                .WriteLine("Самое длинное слово - {0},\nсамое короткое слово - {1}.",
                word_max,
                word_min);
        }
    }
}
