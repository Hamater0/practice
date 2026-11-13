using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task12_Palindrome : ITask
    {
        public string Title => "==================================================\r\nЗадание 12. Палиндром (без учёта регистра/пробелов)\r\n--------------------------------------------------";
        public string Description => "Описание: проверить, является ли строка палиндромом.             ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИгнорировать регистр (`ToLower`/`ToUpper`).\r\nИгнорировать пробелы и знаки пунктуации (или хотя бы пробелы).\r\nНе использовать LINQ Reverse.\r\nПустая строка и строка из одного символа — палиндром." };
        public void Run()
        {
        
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.Write("Введите строку для проверки: ");
            string input = Console.ReadLine();
            string cleaned = CleanString(input);

            bool isPalindrome = IsPalindrome(cleaned);

         
            if (isPalindrome)
            {
                Console.WriteLine("Результат: True (Это палиндром!)");
            }
            else
            {
                Console.WriteLine("Результат: False (Это НЕ палиндром)");
            }

            Console.ReadLine();
        }

        private string CleanString(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            string result = "";
            string lowered = text.ToLower();

            foreach (char c in lowered)
            {
              
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }


        private bool IsPalindrome(string text)
        {
    
            if (text.Length <= 1) return true;

            int left = 0;                 
            int right = text.Length - 1;   

           
            while (left < right)
            {
               
                if (text[left] != text[right])
                {
                    return false;
                }

                left++;  
                right--; 
            }

           
            return true;
        }
    }
}

