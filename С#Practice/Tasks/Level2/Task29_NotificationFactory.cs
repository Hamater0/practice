using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public enum NotificationType
    {
        Email,
        Sms,
        Push
    }

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"[Email] Отправлено письмо: {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"[SMS] Отправлено сообщение: {message}");
    }

    public class PushNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"[Push] Отправлено push-уведомление: {message}");
    }

    public static class NotificationFactory
    {
        public static INotification Create(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email: return new EmailNotification();
                case NotificationType.Sms: return new SmsNotification();
                case NotificationType.Push: return new PushNotification();
                default: throw new ArgumentOutOfRangeException(nameof(type), type, "Неизвестный тип уведомления.");
            }
        }
    }

    public class Task29_NotificationFactory : ITask
    {
        public string Title => "==================================================\r\nЗадание 29. Паттерн «Фабрика» (уведомления)\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать фабрику уведомлений. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nИнтерфейс INotification с методом Send(string message).\r\nРеализации: EmailNotification, SmsNotification, PushNotification.\r\nNotificationFactory.Create(NotificationType type) — возвращает нужную реализацию.\r\nenum NotificationType { Email, Sms, Push }.\r\nПродемонстрировать создание и отправку через фабрику." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            foreach (NotificationType type in Enum.GetValues(typeof(NotificationType)))
            {
                INotification notification = NotificationFactory.Create(type);
                Console.WriteLine($"Тип {type} -> создан {notification.GetType().Name}");
                notification.Send("Ваш заказ отправлен!");
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
