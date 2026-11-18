using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Task21_EnumDays : ITask
    {
        public string Title => "==================================================\r\nЗадание 21. enum дни недели\r\n--------------------------------------------------";
        public string Description => "Описание: описать дни недели через enum и определить тип дня. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nenum DayOfWeek { Monday, ..., Sunday }.\r\nМетод IsWeekend(DayOfWeek day) — true для субботы и воскресенья.\r\nМетод GetRussianName(DayOfWeek day) — возвращает название на русском.\r\nПродемонстрировать на всех 7 днях." };

        private static bool IsWeekend(DayOfWeek day)
        {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }

        private static string GetRussianName(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "Понедельник";
                case DayOfWeek.Tuesday: return "Вторник";
                case DayOfWeek.Wednesday: return "Среда";
                case DayOfWeek.Thursday: return "Четверг";
                case DayOfWeek.Friday: return "Пятница";
                case DayOfWeek.Saturday: return "Суббота";
                case DayOfWeek.Sunday: return "Воскресенье";
                default: return "Неизвестный день";
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

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                string type = IsWeekend(day) ? "выходной" : "рабочий день";
                Console.WriteLine($"{day,-10} -> {GetRussianName(day),-12} ({type}), IsWeekend = {IsWeekend(day)}");
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
