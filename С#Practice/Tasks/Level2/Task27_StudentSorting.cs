using System;
using System.Collections.Generic;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return other.AverageGrade.CompareTo(AverageGrade);
        }

        public override string ToString() => $"{Name,-10} {AverageGrade:F1}";
    }

    public class ByNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return string.Compare(x?.Name, y?.Name, StringComparison.CurrentCulture);
        }
    }

    public class Task27_StudentSorting : ITask
    {
        public string Title => "==================================================\r\nЗадание 27. IComparable / IComparer<T> для Student\r\n--------------------------------------------------";
        public string Description => "Описание: научить Student сортироваться. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nКласс Student: Name, AverageGrade.\r\nРеализовать IComparable<Student> — сортировка по среднему баллу (по убыванию).\r\nРеализовать IComparer<Student> ByNameComparer — сортировка по имени.\r\nПродемонстрировать обе сортировки на List<Student>." };

        private static void Print(List<Student> students)
        {
            foreach (Student s in students)
                Console.WriteLine($"  {s}");
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<Student> students = new List<Student>
            {
                new Student("Иван", 4.2),
                new Student("Анна", 4.8),
                new Student("Борис", 3.9),
                new Student("Виктор", 4.5)
            };

            students.Sort();
            Console.WriteLine("По среднему баллу (убывание):");
            Print(students);

            students.Sort(new ByNameComparer());
            Console.WriteLine();
            Console.WriteLine("По имени (А–Я):");
            Print(students);

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
