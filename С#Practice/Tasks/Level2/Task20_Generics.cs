using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public static class GenericHelpers
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
    }

    public class Task20_Generics : ITask
    {
        public string Title => "==================================================\r\nЗадание 20. Обобщения: Swap<T>, Max<T> с IComparable<T>\r\n--------------------------------------------------";
        public string Description => "Описание: написать обобщённые методы. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nSwap<T>(ref T a, ref T b) — меняет значения местами.\r\nMax<T>(T a, T b) where T : IComparable<T> — возвращает большее.\r\nПродемонстрировать на int, string, double.\r\nSwap — без ограничений, Max — с ограничением." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            int i1 = 5, i2 = 9;
            Console.WriteLine($"int:    до Swap: {i1}, {i2}");
            GenericHelpers.Swap(ref i1, ref i2);
            Console.WriteLine($"        после Swap: {i1}, {i2}; Max = {GenericHelpers.Max(i1, i2)}");

            string s1 = "apple", s2 = "banana";
            Console.WriteLine($"string: до Swap: {s1}, {s2}");
            GenericHelpers.Swap(ref s1, ref s2);
            Console.WriteLine($"        после Swap: {s1}, {s2}; Max = {GenericHelpers.Max(s1, s2)}");

            double d1 = 3.14, d2 = 2.71;
            Console.WriteLine($"double: до Swap: {d1}, {d2}");
            GenericHelpers.Swap(ref d1, ref d2);
            Console.WriteLine($"        после Swap: {d1}, {d2}; Max = {GenericHelpers.Max(d1, d2)}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
