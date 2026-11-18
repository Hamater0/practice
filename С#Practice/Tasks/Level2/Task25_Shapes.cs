using System;
using System.Collections.Generic;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public interface IShape
    {
        double Area();
        double Perimeter();
    }

    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius) { Radius = radius; }
        public double Area() => Math.PI * Radius * Radius;
        public double Perimeter() => 2 * Math.PI * Radius;
        public override string ToString() => $"Circle(r={Radius})";
    }

    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height) { Width = width; Height = height; }
        public double Area() => Width * Height;
        public double Perimeter() => 2 * (Width + Height);
        public override string ToString() => $"Rectangle({Width}x{Height})";
    }

    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Triangle(double a, double b, double c) { A = a; B = b; C = c; }
        public double Perimeter() => A + B + C;
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override string ToString() => $"Triangle({A}, {B}, {C})";
    }

    public class Task25_Shapes : ITask
    {
        public string Title => "==================================================\r\nЗадание 25. Интерфейс IShape + сортировка фигур\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать интерфейс фигур и отсортировать их. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nIShape с методами Area() и Perimeter().\r\nКлассы Circle, Rectangle, Triangle — реализуют IShape.\r\nСоздать List<IShape> из 5+ фигур.\r\nОтсортировать по площади (List.Sort с лямбдой или OrderBy).\r\nВывести фигуры с площадями до и после сортировки." };

        private static void Print(List<IShape> shapes)
        {
            foreach (IShape s in shapes)
                Console.WriteLine($"  {s,-22} площадь = {s.Area():F2}, периметр = {s.Perimeter():F2}");
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<IShape> shapes = new List<IShape>
            {
                new Circle(3),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5),
                new Circle(1),
                new Rectangle(2, 2),
                new Triangle(6, 8, 10)
            };

            Console.WriteLine("До сортировки:");
            Print(shapes);

            shapes.Sort((a, b) => a.Area().CompareTo(b.Area()));

            Console.WriteLine();
            Console.WriteLine("После сортировки по возрастанию площади:");
            Print(shapes);

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
