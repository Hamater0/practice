using System;
using System.Collections.Generic;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Point : IEquatable<Point>
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj) => Equals(obj as Point);

        public override int GetHashCode() => HashCode.Combine(X, Y);

        public override string ToString() => $"({X}, {Y})";
    }

    public class Task28_PointEquals : ITask
    {
        public string Title => "==================================================\r\nЗадание 28. Equals / GetHashCode для Point\r\n--------------------------------------------------";
        public string Description => "Описание: переопределить Equals и GetHashCode для класса Point(x, y). ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nПереопределить Equals(object) и GetHashCode().\r\nРеализовать IEquatable<Point>.\r\nПроверить: две точки с одинаковыми координатами равны.\r\nПроверить в HashSet<Point>: добавление дубликата не увеличивает Count." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(3, 4);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
            Console.WriteLine($"a.Equals((object)b): {a.Equals((object)b)}");
            Console.WriteLine($"a.Equals(c): {a.Equals(c)}");
            Console.WriteLine($"Хэш-коды a и b равны: {a.GetHashCode() == b.GetHashCode()}");

            HashSet<Point> set = new HashSet<Point>();
            Console.WriteLine();
            Console.WriteLine($"Add(a) -> {set.Add(a)}, Count = {set.Count}");
            Console.WriteLine($"Add(b) (дубликат) -> {set.Add(b)}, Count = {set.Count}");
            Console.WriteLine($"Add(c) -> {set.Add(c)}, Count = {set.Count}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
