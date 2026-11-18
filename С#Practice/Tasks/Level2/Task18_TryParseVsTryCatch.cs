using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Task18_TryParseVsTryCatch : ITask
    {
        public string Title => "==================================================\r\nЗадание 18. TryParse vs try/catch\r\n--------------------------------------------------";
        public string Description => "Описание: сравнить два способа обработки некорректного ввода числа. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСпособ 1: int.TryParse — вернуть bool + значение через out.\r\nСпособ 2: int.Parse внутри try/catch — ловить FormatException.\r\nОба оформить отдельными методами.\r\nПродемонстрировать на корректном и некорректном вводе." };

        private static bool ParseWithTryParse(string input, out int value)
        {
            return int.TryParse(input, out value);
        }

        private static bool ParseWithTryCatch(string input, out int value)
        {
            try
            {
                value = int.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                value = 0;
                return false;
            }
            catch (OverflowException)
            {
                value = 0;
                return false;
            }
            catch (ArgumentNullException)
            {
                value = 0;
                return false;
            }
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            string[] inputs = { "123", "abc" };

            foreach (string input in inputs)
            {
                bool ok1 = ParseWithTryParse(input, out int v1);
                bool ok2 = ParseWithTryCatch(input, out int v2);

                Console.WriteLine($"Ввод: \"{input}\"");
                Console.WriteLine($"  TryParse:  успех = {ok1}, значение = {v1}");
                Console.WriteLine($"  try/catch: успех = {ok2}, значение = {v2}");
            }

            Console.WriteLine();
            Console.WriteLine("Вывод: TryParse быстрее и чище — исключение дорогое и для ожидаемой ошибки ввода не нужно.");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
