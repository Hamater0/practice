using System;
using System.Collections.Generic;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

    public class Task23_Nullable : ITask
    {
        public string Title => "==================================================\r\nЗадание 23. Nullable-типы, ??, ?.\r\n--------------------------------------------------";
        public string Description => "Описание: продемонстрировать работу с nullable. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nМетод int? FindValue(string key) — возвращает null, если ключа нет.\r\nИспользовать ?? для значения по умолчанию.\r\nИспользовать ?. для безопасного доступа к свойству объекта, который может быть null.\r\nИспользовать HasValue / Value с проверкой.\r\nПродемонстрировать на найденном и ненайденном ключе." };

        private static readonly Dictionary<string, int> Storage = new Dictionary<string, int>
        {
            { "age", 25 },
            { "year", 2026 }
        };

        private static int? FindValue(string key)
        {
            if (key != null && Storage.TryGetValue(key, out int value))
                return value;
            return null;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            string[] keys = { "age", "height" };

            foreach (string key in keys)
            {
                int? result = FindValue(key);
                Console.WriteLine($"Ключ \"{key}\":");

                if (result.HasValue)
                    Console.WriteLine($"  HasValue = true, Value = {result.Value}");
                else
                    Console.WriteLine("  HasValue = false (значения нет)");

                int withDefault = result ?? -1;
                Console.WriteLine($"  result ?? -1 = {withDefault}");
            }

            Person existing = new Person { Name = "Анна", City = "Москва" };
            Person missing = null;

            Console.WriteLine();
            Console.WriteLine($"existing?.Name = {existing?.Name}");
            Console.WriteLine($"missing?.Name  = {missing?.Name ?? "(null, без падения)"}");
            Console.WriteLine($"missing?.City?.Length = {missing?.City?.Length}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
