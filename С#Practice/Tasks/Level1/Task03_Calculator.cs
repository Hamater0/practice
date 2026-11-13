using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;
namespace С_Practice.Tasks.Level1
{
    public class Task03_Calculator : ITask
    {
        public string Title => "==================================================\r\nЗадание 3. Калькулятор\r\n--------------------------------------------------";
       public string Description => "Описание:\r\n  Принимает два числа и оператор (+, -, *, /),\r\n  выводит результат. Обработать деление на ноль.";
        public string[] Requirements => new string[] { "Требования:\r\n  - Использовать switch для оператора\r\n  - Не допускать падения при делении на ноль\r\n--------------------------------------------------\r\n" };
       
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30)); 
            Console.WriteLine();
            Console.Write("первое число");
            double a = double.Parse(Console.ReadLine());
            Console.Write("второе число");
            double b = double.Parse(Console.ReadLine());
            Console.Write("введите оператор + - / *");
            string c = Console.ReadLine();
            double result = 0;
            switch (c)
            {
                case "+":
                   result= a + b;
                    break;

                case "-":
                    result  = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;
                case "/":
                    if(b == 0)
                    {
                        Console.WriteLine("Ошибка, деление на ноль запрещено");
                        break;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Введен неверный оператор");
                    break;

            }
            Console.WriteLine($"Результат вычисления = {result}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }

        
    }
}
