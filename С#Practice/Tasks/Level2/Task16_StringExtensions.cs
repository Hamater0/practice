using System;
using System.Linq;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            string cleaned = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
            if (cleaned.Length == 0) return false;
            return cleaned.SequenceEqual(cleaned.Reverse());
        }

        public static int WordCount(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '—', '"', '(', ')', '\n', '\r', '\t' };
            return s.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ReverseString(this string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    public class Task16_StringExtensions : ITask
    {
        public string Title => "==================================================\r\nЗадание 16. Методы расширения для string\r\n--------------------------------------------------";
        public string Description => "Описание: написать extension-методы для string. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nРеализовать в статическом классе StringExtensions.\r\nМетоды: IsPalindrome(), WordCount(), ReverseString().\r\nМетоды public static с this string первым параметром.\r\nПродемонстрировать вызов на 2–3 строках." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            string[] samples = { "А роза упала на лапу Азора", "Hello, world! Это тест", "abc" };

            foreach (string s in samples)
            {
                Console.WriteLine($"Строка:        \"{s}\"");
                Console.WriteLine($"IsPalindrome:  {s.IsPalindrome()}");
                Console.WriteLine($"WordCount:     {s.WordCount()}");
                Console.WriteLine($"ReverseString: \"{s.ReverseString()}\"");
                Console.WriteLine(new string('-', 30));
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
