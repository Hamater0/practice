using System;
using System.Collections.Generic;
using System.Linq;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Task34_LinqGroupWords : ITask
    {
        public string Title => "==================================================\r\nЗадание 34. LINQ: группировка слов по первой букве\r\n--------------------------------------------------";
        public string Description => "Описание: сгруппировать слова по первой букве. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nВзять список слов (10+).\r\nСгруппировать через LINQ GroupBy(w => w[0]).\r\nОтсортировать группы по первой букве.\r\nВнутри группы — отсортировать слова.\r\nВывести «Буква: слово1, слово2, ...»." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<string> words = new List<string>
            {
                "яблоко", "арбуз", "банан", "виноград", "апельсин", "груша",
                "вишня", "берёза", "гранат", "абрикос", "ананас", "брусника"
            };

            var groups = words
                .GroupBy(w => w[0])
                .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                string sorted = string.Join(", ", group.OrderBy(w => w));
                Console.WriteLine($"{char.ToUpper(group.Key)}: {sorted}");
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
