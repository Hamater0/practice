using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;


namespace С_Practice.Tasks.Level1
{
    public class Task06_Summa :ITask
    {
        public string Title => "==================================================\r\nЗадание 6. Сумма цифр числа (строка + арифметика)\r\n--------------------------------------------------";
        public string Description => "Описание:найти сумму цифр введённого числа (например, 1234 → 10).     ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСпособ 1 (строка): число → ToString() → пройти по символам → int.Parse каждой цифры.\r\nСпособ 2 (арифметика): цикл while (n > 0) { sum += n % 10; n /= 10; }.\r\nОба способа оформить отдельными методами.\r\nОтрицательные числа — брать модуль." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.Write("Введите число");
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            string b = a.ToString();
            
            int result = 0;
            foreach(char c in b){
                result += int.Parse(c.ToString());
                Console.WriteLine(result);
                
            }
            Console.WriteLine("\nНажмите Enter для следующего метода");
            Console.ReadLine();

        }
        public void Run2()
        {
            Console.Write("Введите число");
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine($"{sum}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
       
    }
}
