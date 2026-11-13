using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task09_Array :ITask
    {
        public string Title => "==================================================\r\nЗадание 9. Массивы: min/max/sum/avg\r\n--------------------------------------------------";
        public string Description => "Описание: для массива чисел найти минимум, максимум, сумму и среднее.         ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nЗаполнить массив (например, случайными числами 1–100, размер 20).\r\nРеализовать без LINQ (`Min/Max/Sum/Average` запрещены).\r\nОформить 4 отдельных метода.\r\nПустой массив — обработать (вернуть ошибку или 0, но не падать)." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Random rnd = new Random();
            int[] a = new int[20];
            Console.Write("Массив чисел: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1,101);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n---------------------------------");

            int min = GetMin(a);
            int max = GetMax(a);
            int sum = GetSum(a);
            double avg = GetAverage(a);

      
            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее: {avg:F2}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
        public int GetMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0; 

            int min = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i]; 
                }
            }
            return min; 
        }
        public int GetMax(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int max  = arr[0];
            for(int i= 1; i<arr.Length; i++) {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
               
                 }
            return max;
        
        }
        public int GetSum(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int sum = arr[0];
            for(int i= 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public double GetAverage(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int sum = GetSum(arr);
            return (double)sum / arr.Length;
        }
}
}