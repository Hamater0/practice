using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task14_Age :ITask
    {
        public string Title => "==================================================\r\nЗадание 14. Возраст по дате рождения\r\n--------------------------------------------------";
        public string Description => "Описание:по дате рождения вычислить точный возраст в годах, месяцах и днях.   ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nВвод даты через DateTime.TryParse (или `TryParseExact`).\r\nУчесть, что день рождения в этом году мог ещё не наступить.\r\nВывести «X лет, Y месяцев, Z дней».\r\nНекорректная дата — сообщение об ошибке, не падать." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Console.Write("Введите дату рождения (например, 15.05.2000): ");
            string input = Console.ReadLine();

           
            if (!DateTime.TryParse(input, out DateTime birthDate))
            {
                Console.WriteLine("Ошибка: некорректный формат даты.");
                return;
            }

            DateTime today = DateTime.Today;

           
            if (birthDate > today)
            {
                Console.WriteLine("Ошибка: дата рождения не может быть в будущем.");
                return;
            }

          
            int years = today.Year - birthDate.Year;
            int months = today.Month - birthDate.Month;
            int days = today.Day - birthDate.Day;

          
            if (days < 0)
            {
                months--;
                DateTime previousMonth = today.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

           
            Console.WriteLine($"\nВаш точный возраст: {years} лет, {months} месяцев, {days} дней");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
        