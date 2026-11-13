using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace C_Practice.Tasks.Level1
    {
        public class Task13_Counter : ITask
        {
        public string Title => "==================================================\r\nЗадание 13. Счётчик вхождений слов в тексте (Dictionary)\r\n--------------------------------------------------";
        public string Description => "Описание: посчитать, сколько раз каждое слово встречается в тексте. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИспользовать Dictionary<string, int>.\r\nРазбить текст на слова (по пробелам и знакам пунктуации).\r\nПривести слова к нижнему регистру.\r\nВывести пары «слово → количество», отсортированные по убыванию количества." };

        public void Run()
            {
                Console.Clear();
                Console.WriteLine(Title);
                Console.WriteLine(Description);
                Console.WriteLine(string.Join("\n", Requirements));
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                Console.WriteLine();
                Console.WriteLine("Введите текст для подсчёта слов и нажмите Enter:");
                string text = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Текст не введён. Подсчёт невозможен.");
                    return;
                }

                char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '—', '"', '(', ')', '\n', '\r', '\t' };
                string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> wordCounts = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    string lowerWord = word.ToLower();

                    if (wordCounts.ContainsKey(lowerWord))
                    {
                        wordCounts[lowerWord]++;
                    }
                    else
                    {
                        wordCounts[lowerWord] = 1;
                    }
                }

                var sortedWords = wordCounts.OrderByDescending(pair => pair.Value);

                Console.WriteLine("\nРезультат подсчёта:");
                foreach (var pair in sortedWords)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");

                }
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
        }
    }
