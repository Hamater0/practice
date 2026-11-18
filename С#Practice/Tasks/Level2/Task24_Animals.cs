using System;
using System.Collections.Generic;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"{GetType().Name} по имени {Name}";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override string MakeSound() => "Гав-гав!";
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override string MakeSound() => "Мяу!";
    }

    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override string MakeSound() => "Чирик-чирик!";
        public string Fly() => $"{Name} взлетает в небо.";
    }

    public class Task24_Animals : ITask
    {
        public string Title => "==================================================\r\nЗадание 24. ООП: Animal → Dog/Cat/Bird\r\n--------------------------------------------------";
        public string Description => "Описание: построить иерархию животных. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nАбстрактный класс Animal: свойство Name, абстрактный метод MakeSound(), переопределённый ToString().\r\nКлассы Dog, Cat, Bird — наследники, реализуют MakeSound().\r\nBird дополнительно имеет метод Fly().\r\nПродемонстрировать полиморфизм: List<Animal>, вызов MakeSound() в цикле." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<Animal> animals = new List<Animal>
            {
                new Dog("Шарик"),
                new Cat("Мурка"),
                new Bird("Кеша"),
                new Dog("Бобик")
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal} говорит: {animal.MakeSound()}");

                if (animal is Bird bird)
                    Console.WriteLine($"  {bird.Fly()}");
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
