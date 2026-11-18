using System;
using System.Diagnostics;
using System.Text;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Task17_StringBuilderVsConcat : ITask
    {
        public string Title => "==================================================\r\nЗадание 17. StringBuilder vs конкатенация (замер)\r\n--------------------------------------------------";
        public string Description => "Описание: сравнить производительность конкатенации через + и StringBuilder. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСобрать строку из 10 000 (или 100 000) чисел двумя способами.\r\nЗамерить время каждого через Stopwatch.\r\nВывести оба времени и разницу.\r\nОбъяснить в комментарии, почему StringBuilder быстрее." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            const int count = 10000;

            Stopwatch sw = Stopwatch.StartNew();
            string concat = "";
            for (int i = 0; i < count; i++)
            {
                concat += i + ",";
            }
            sw.Stop();
            double concatMs = sw.Elapsed.TotalMilliseconds;

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(i).Append(',');
            }
            string built = sb.ToString();
            sw.Stop();
            double sbMs = sw.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Конкатенация (+): {concatMs:F3} мс");
            Console.WriteLine($"StringBuilder:    {sbMs:F3} мс");
            Console.WriteLine($"Разница:          {concatMs - sbMs:F3} мс");
            if (sbMs > 0)
                Console.WriteLine($"StringBuilder быстрее в {concatMs / sbMs:F1} раз");
            Console.WriteLine($"Содержимое строк совпадает: {concat == built}");

            // Почему StringBuilder быстрее:
            // string в .NET неизменяема (immutable). Каждая операция s += x создаёт НОВУЮ строку:
            // выделяется память под (старая длина + новая часть) и старое содержимое копируется целиком.
            // При N итерациях копируется O(N^2) символов, плюс много мусора для сборщика.
            // StringBuilder держит изменяемый буфер, дописывает в него и расширяет его редко (с запасом),
            // поэтому суммарно работа ~O(N).

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
