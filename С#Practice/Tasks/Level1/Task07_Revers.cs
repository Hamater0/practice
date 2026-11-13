using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task07_Revers :ITask
    {
        public string Title => "==================================================\r\nЗадание 7. Реверс строки без LINQ\r\n--------------------------------------------------";
        public string Description => "Описание: перевернуть введённую строку.       ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nНе использовать Array.Reverse и LINQ.\r\nРеализовать через цикл for от конца к началу (или через char[] и swap).\r\nПустая строка и строка из одного символа — обрабатываются корректно." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.Write("Введите строку ");
            string text = Console.ReadLine();
            string revers = "";
            for (int i = text.Length - 1; i>=0; i--)
            {
                revers += text[i] ;

            }
            Console.WriteLine($"{revers}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
