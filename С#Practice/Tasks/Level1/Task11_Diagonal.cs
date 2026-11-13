using System;
using System.Collections.Generic;
using System.Text;
using С_Practice.Common;

namespace С_Practice.Tasks.Level1
{
    public class Task11_Diagonal : ITask
    {
        public string Title => "==================================================\r\nЗадание 11. Диагональ матрицы N×N\r\n--------------------------------------------------";
        public string Description => "Описание: найти сумму элементов главной диагонали матрицы N×N.           ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nРазмер N вводится пользователем (минимум 2).\r\nМатрица заполняется случайными числами.\r\nСумма считается без LINQ, в одном цикле for.\r\nВывести саму матрицу и сумму." };
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.Write("Введите размер матрицы N (минимум 2)");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
               
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i]; 
            }

            Console.WriteLine($"\nСумма элементов главной диагонали: {sum}");
            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}