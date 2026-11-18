using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public interface IDiscountStrategy
    {
        decimal Apply(decimal price);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price;
    }

    public class VipDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.90m;
    }

    public class PromoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.80m;
    }

    public class PriceCalculator
    {
        private readonly IDiscountStrategy _strategy;

        public PriceCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public decimal Calculate(decimal price) => _strategy.Apply(price);
    }

    public class Task26_DiscountStrategy : ITask
    {
        public string Title => "==================================================\r\nЗадание 26. Паттерн «Стратегия» (скидки)\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать калькулятор скидок через паттерн «Стратегия». ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИнтерфейс IDiscountStrategy с методом Apply(decimal price).\r\nРеализации: NoDiscount, VipDiscount (10%), PromoDiscount (20%).\r\nКласс PriceCalculator, принимающий стратегию в конструкторе.\r\nПродемонстрировать расчёт цены с каждой стратегией." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            decimal price = 1000m;
            Console.WriteLine($"Исходная цена: {price:F2}");

            PriceCalculator noDiscount = new PriceCalculator(new NoDiscount());
            PriceCalculator vip = new PriceCalculator(new VipDiscount());
            PriceCalculator promo = new PriceCalculator(new PromoDiscount());

            Console.WriteLine($"NoDiscount:    {noDiscount.Calculate(price):F2}");
            Console.WriteLine($"VipDiscount:   {vip.Calculate(price):F2}");
            Console.WriteLine($"PromoDiscount: {promo.Calculate(price):F2}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
