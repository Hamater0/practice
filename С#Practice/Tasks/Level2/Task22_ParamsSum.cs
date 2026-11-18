using System;
using System.Collections.Generic;
using System.Linq;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Task22_ParamsSum : ITask
    {
        public string Title => "==================================================\r\nЗадание 22. params-метод + перегрузка\r\n--------------------------------------------------";
        public string Description => "Описание: написать метод суммы с params и его перегрузку. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nSum(params int[] numbers) — сумма произвольного числа чисел.\r\nПерегрузка для коллекции — та же логика.\r\nПродемонстрировать: Sum(1, 2, 3), Sum(new[] {1, 2, 3}), Sum().\r\nПустой вызов — вернуть 0." };

        public static int Sum(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int total = 0;
            foreach (int n in numbers) total += n;
            return total;
        }

        public static int Sum(IEnumerable<int> numbers)
        {
            if (numbers == null) return 0;
            return Sum(numbers.ToArray());
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Console.WriteLine($"Sum(1, 2, 3)             = {Sum(1, 2, 3)}");
            Console.WriteLine($"Sum(new[] {{1, 2, 3}})     = {Sum(new[] { 1, 2, 3 })}");
            Console.WriteLine($"Sum(List<int> {{1, 2, 3}}) = {Sum(new List<int> { 1, 2, 3 })}");
            Console.WriteLine($"Sum()                    = {Sum()}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
