using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task08__FizzBuzz :ITask
    {
        public string Title => "==================================================\r\nЗадание 8. FizzBuzz 1–100\r\n--------------------------------------------------";
        public string Description => "Описание: вывести числа от 1 до 100 с заменами.        ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nКратно 3 → Fizz.\r\nКратно 5 → Buzz.\r\nКратно 15 → FizzBuzz.\r\nИначе — само число.\r\nПорядок проверок: сначала 15, потом 3 и 5." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            for (int i = 1; i <=100; i++)
            {
               
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        
            
                }
            }
        }
    

