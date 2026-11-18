using System;
using System.Collections.Generic;
using System.Linq;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, decimal salary, string department)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public override string ToString() => $"{Name,-10} {Age,3} лет  {Salary,9:F2}  {Department}";
    }

    public class Task33_LinqEmployees : ITask
    {
        public string Title => "==================================================\r\nЗадание 33. LINQ: сотрудники (top-3, avg по отделу, фильтр)\r\n--------------------------------------------------";
        public string Description => "Описание: LINQ-запросы по списку сотрудников. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nКласс Employee: Name, Age, Salary, Department.\r\nСписок из 10+ сотрудников.\r\nЗапросы через LINQ: топ-3 по зарплате (убывание); средняя зарплата по каждому отделу (GroupBy + Average); сотрудники старше 30 (Where).\r\nВывести результаты." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<Employee> employees = new List<Employee>
            {
                new Employee("Иван", 28, 85000m, "IT"),
                new Employee("Мария", 34, 120000m, "IT"),
                new Employee("Пётр", 45, 95000m, "Бухгалтерия"),
                new Employee("Ольга", 29, 70000m, "Маркетинг"),
                new Employee("Алексей", 38, 150000m, "IT"),
                new Employee("Светлана", 31, 90000m, "Бухгалтерия"),
                new Employee("Дмитрий", 25, 60000m, "Маркетинг"),
                new Employee("Елена", 52, 110000m, "HR"),
                new Employee("Николай", 30, 65000m, "HR"),
                new Employee("Анна", 41, 105000m, "Маркетинг"),
                new Employee("Сергей", 27, 78000m, "IT")
            };

            Console.WriteLine("Топ-3 по зарплате:");
            var top3 = employees.OrderByDescending(e => e.Salary).Take(3);
            foreach (var e in top3)
                Console.WriteLine($"  {e}");

            Console.WriteLine();
            Console.WriteLine("Средняя зарплата по отделам:");
            var avgByDept = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, Average = g.Average(e => e.Salary) });
            foreach (var item in avgByDept)
                Console.WriteLine($"  {item.Department,-12} {item.Average:F2}");

            Console.WriteLine();
            Console.WriteLine("Сотрудники старше 30:");
            var older = employees.Where(e => e.Age > 30);
            foreach (var e in older)
                Console.WriteLine($"  {e}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
