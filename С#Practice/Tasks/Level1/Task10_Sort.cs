using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using С_Practice.Common;
namespace С_Practice.Tasks.Level1
{
    public class Task10_Sort : ITask
    {
        public string Title => "==================================================\r\nЗадание 10. Сортировка пузырьком + вставками\r\n--------------------------------------------------";
        public string Description => "Описание: отсортировать массив двумя алгоритмами.         ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nРеализовать BubbleSort и InsertionSort отдельными методами.\r\nОба — без LINQ и Array.Sort.\r\nЗамерить время каждого через Stopwatch на массиве 10 000 элементов.\r\nВывести оба времени." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Random rnd = new Random();
            int[] a = new int[10000];
            for(int i=0; i<a.Length; i++)
            {
                a[i] = rnd.Next(1,10000);
            }
            int[] arrayForBubble = (int[])a.Clone();
            int[] arrayForInsertion = (int[])a.Clone();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort(arrayForBubble);
            sw.Stop();
            Console.WriteLine($"Пузырёк отсортировал за: {sw.ElapsedMilliseconds} мс");
            sw.Reset();
            sw.Start();
            InsertionSort(arrayForInsertion);
            sw.Stop();
            Console.WriteLine($"Вставки отсортировали за: {sw.ElapsedMilliseconds} мс");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
        public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                       
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }


    }
}
