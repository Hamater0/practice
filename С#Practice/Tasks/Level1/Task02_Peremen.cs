using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task02_Peremen : ITask

    {
        public string Title => "==================================================\r\nЗадание 2. Переменные примитивных типов\r\n--------------------------------------------------";
        public string Description => "объявить переменные всех примитивных типов и вывести их значения и типы. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nОбъявить минимум: int, long, double, float, decimal, bool, char, string.\r\nДля каждой переменной вывести значение и GetType().Name.\r\ndecimal — с суффиксом m, float — с f." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            int a = 35;
            long b = 2000000000000000;
            double c =1.5;
            float d = 5.2f;
            decimal f = 6m;
            bool g = true;
            char h = 'a';
            string j = "b";
            Console.WriteLine($"a = {a} ({a.GetType().Name})");
            Console.WriteLine($"b = {b} ({b.GetType().Name})");
            Console.WriteLine($"c = {c} ({c.GetType().Name})");
            Console.WriteLine($"d = {d} ({d.GetType().Name})");
            Console.WriteLine($"f = {f} ({f.GetType().Name})");
            Console.WriteLine($"g = {g} ({g.GetType().Name})");
            Console.WriteLine($"h = {h} ({h.GetType().Name})");
            Console.WriteLine($"j = {j} ({j.GetType().Name})");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine(); 
        }
    }
}
