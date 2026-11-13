using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task04_Parity : ITask
    {
        public string Title => "==================================================\r\nЗадание 4. Чётность числа (два способа)\r\n--------------------------------------------------";
        public string Description => "Описание:определить, чётное ли введённое число.  ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСпособ 1: через % 2 == 0.\r\nСпособ 2: через тернарный оператор ? :.\r\nОба способа реализовать отдельными методами.\r\nВывести результат обоих способов." };

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
            if (a % 2 == 0)
            {
                Console.WriteLine($"число {a} четное");
                Console.WriteLine("\nНажмите Enter для следующего метода");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Введенное число {a} не четное");
                Console.WriteLine("\nНажмите Enter для следующего метода");
                Console.ReadLine();

            }
           
          
        }
        public void Run2()
        { 
                Console.Write("Введите число (Способ 2):");
                int a = int.Parse(Console.ReadLine());

                string result = (a % 2 == 0) ? $"число {a} четное" : $"Введенное число {a} не четное";

                Console.WriteLine(result);
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
            
        }
    }
}
