using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Text;

namespace С_Practice.Tasks.Level1
{
    public class Task01_HelloWorld
    {
        public string Title => "==================================================\r\nЗадание 1. Hello, World + текущая дата\r\n--------------------------------------------------";
        public string Description => "вывести приветствие и текущую дату. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИспользовать Console.WriteLine.\r\nДату получить через DateTime.Now, отформатировать как dd.MM.yyyy.\r\nВывести две строки: приветствие и дату.." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd.MM.yyyy");
            Console.WriteLine("HelloWorld");
            Console.WriteLine($"{formattedDate}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();



        }
        }
        
    }

