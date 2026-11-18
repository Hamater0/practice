using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Temperature
    {
        private const double AbsoluteZero = -273.15;
        private double _celsius;

        public double Celsius
        {
            get => _celsius;
            set
            {
                if (value < AbsoluteZero)
                    throw new ArgumentOutOfRangeException(nameof(Celsius), value,
                        $"Температура не может быть ниже {AbsoluteZero} °C.");
                _celsius = value;
            }
        }

        public double Fahrenheit => _celsius * 9 / 5 + 32;
    }

    public class Task32_Temperature : ITask
    {
        public string Title => "==================================================\r\nЗадание 32. Свойства с валидацией (Temperature)\r\n--------------------------------------------------";
        public string Description => "Описание: класс Temperature с валидацией в set. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСвойство Celsius с проверкой в set: не ниже −273.15.\r\nПри некорректном значении — бросать ArgumentOutOfRangeException.\r\nВычисляемое свойство Fahrenheit (только get).\r\nПродемонстрировать корректное и некорректное присваивание." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Temperature t = new Temperature();

            t.Celsius = 25;
            Console.WriteLine($"Celsius = {t.Celsius}, Fahrenheit = {t.Fahrenheit:F1}");

            t.Celsius = 100;
            Console.WriteLine($"Celsius = {t.Celsius}, Fahrenheit = {t.Fahrenheit:F1}");

            t.Celsius = -273.15;
            Console.WriteLine($"Celsius = {t.Celsius}, Fahrenheit = {t.Fahrenheit:F2} (абсолютный ноль допустим)");

            try
            {
                Console.WriteLine("Пробуем присвоить -300...");
                t.Celsius = -300;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine($"Значение не изменилось: Celsius = {t.Celsius}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
