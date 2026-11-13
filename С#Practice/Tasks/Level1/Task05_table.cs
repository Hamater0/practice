using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task05_table :ITask
    {
        public string Title => "==================================================\r\nЗадание 5. Таблица умножения 10*10\r\n--------------------------------------------------";
        public string Description => "Описание:вывести таблицу умножения 10*10.    ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИспользовать вложенные циклы for.\r\nВыровнять столбцы.\r\nЗаголовки строк/столбцов — не обязательны, но приветствуются." };
        public void Run()
        {

            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            { 
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nНажмите Enter для возврата...");
     
            Console.ReadLine();
        }
    }
}
