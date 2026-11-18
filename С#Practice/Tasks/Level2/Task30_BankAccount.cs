using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class InsufficientFundsException : Exception
    {
        public decimal Balance { get; }
        public decimal Requested { get; }

        public InsufficientFundsException(decimal balance, decimal requested)
            : base($"Недостаточно средств: на счёте {balance:F2}, запрошено {requested:F2}.")
        {
            Balance = balance;
            Requested = requested;
        }
    }

    public class BankAccount
    {
        private decimal _balance;

        public decimal Balance => _balance;

        public BankAccount(decimal initialBalance = 0m)
        {
            if (initialBalance < 0) throw new ArgumentOutOfRangeException(nameof(initialBalance));
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной.");
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной.");
            if (amount > _balance) throw new InsufficientFundsException(_balance, amount);
            _balance -= amount;
        }
    }

    public class Task30_BankAccount : ITask
    {
        public string Title => "==================================================\r\nЗадание 30. BankAccount + свой Exception\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать банковский счёт с собственным исключением. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nКласс BankAccount с приватным балансом.\r\nМетоды Deposit(decimal), Withdraw(decimal).\r\nСвой класс InsufficientFundsException : Exception.\r\nWithdraw бросает исключение, если сумма больше баланса.\r\nПродемонстрировать: успешное снятие и попытку снять больше баланса (с try/catch)." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            BankAccount account = new BankAccount(500m);
            Console.WriteLine($"Начальный баланс: {account.Balance:F2}");

            account.Deposit(200m);
            Console.WriteLine($"После пополнения на 200: {account.Balance:F2}");

            account.Withdraw(300m);
            Console.WriteLine($"После снятия 300: {account.Balance:F2}");

            try
            {
                Console.WriteLine("Пробуем снять 1000...");
                account.Withdraw(1000m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine($"Баланс после неудачной попытки: {account.Balance:F2} (не ушёл в минус)");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
