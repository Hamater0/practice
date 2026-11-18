using System;
using System.IO;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class FileWriter : IDisposable
    {
        private StreamWriter _writer;
        private bool _disposed;

        public FileWriter(string path)
        {
            _writer = new StreamWriter(path, false);
        }

        public void WriteLine(string text)
        {
            if (_disposed)
            {
                Console.WriteLine("  (запись после Dispose проигнорирована — файл уже закрыт)");
                return;
            }
            _writer.WriteLine(text);
        }

        public void Dispose()
        {
            if (_disposed) return;
            _writer?.Dispose();
            _writer = null;
            _disposed = true;
            Console.WriteLine("  FileWriter: файл закрыт (Dispose).");
        }
    }

    public class Task31_Disposable : ITask
    {
        public string Title => "==================================================\r\nЗадание 31. IDisposable + using\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать IDisposable для класса, работающего с файлом. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nКласс FileWriter с полем StreamWriter.\r\nРеализовать Dispose() (закрыть StreamWriter).\r\nПродемонстрировать использование через using.\r\nДополнительно: using-декларация (C# 8+, using var)." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            string path1 = Path.Combine(Path.GetTempPath(), "task31_using.txt");
            string path2 = Path.Combine(Path.GetTempPath(), "task31_using_var.txt");

            Console.WriteLine("1. using-блок:");
            FileWriter keep;
            using (FileWriter writer = new FileWriter(path1))
            {
                writer.WriteLine("Первая строка");
                writer.WriteLine("Вторая строка");
                keep = writer;
            }
            keep.WriteLine("Запись после закрытия");
            Console.WriteLine($"  Содержимое файла: {File.ReadAllText(path1).Replace(Environment.NewLine, " | ")}");

            Console.WriteLine();
            Console.WriteLine("2. using var (закроется при выходе из блока ниже):");
            {
                using var writer = new FileWriter(path2);
                writer.WriteLine("Строка через using var");
                Console.WriteLine("  Конец блока...");
            }
            Console.WriteLine($"  Содержимое файла: {File.ReadAllText(path2).Trim()}");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
