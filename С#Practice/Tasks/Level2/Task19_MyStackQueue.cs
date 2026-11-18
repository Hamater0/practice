using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class MyStack<T>
    {
        private T[] _items = new T[4];
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        public void Push(T item)
        {
            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[_count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст.");
            T item = _items[--_count];
            _items[_count] = default(T);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст.");
            return _items[_count - 1];
        }
    }

    public class MyQueue<T>
    {
        private T[] _items = new T[4];
        private int _head;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        public void Enqueue(T item)
        {
            if (_count == _items.Length) Grow();
            _items[(_head + _count) % _items.Length] = item;
            _count++;
        }

        public T Dequeue()
        {
            if (IsEmpty) throw new InvalidOperationException("Очередь пуста.");
            T item = _items[_head];
            _items[_head] = default(T);
            _head = (_head + 1) % _items.Length;
            _count--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Очередь пуста.");
            return _items[_head];
        }

        private void Grow()
        {
            T[] bigger = new T[_items.Length * 2];
            for (int i = 0; i < _count; i++)
                bigger[i] = _items[(_head + i) % _items.Length];
            _items = bigger;
            _head = 0;
        }
    }

    public class Task19_MyStackQueue : ITask
    {
        public string Title => "==================================================\r\nЗадание 19. Свой стек/очередь на массиве\r\n--------------------------------------------------";
        public string Description => "Описание: реализовать MyStack<T> и MyQueue<T> на массиве. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\nСтек: Push, Pop, Peek, Count, IsEmpty.\r\nОчередь: Enqueue, Dequeue, Peek, Count, IsEmpty.\r\nПри переполнении — расширять внутренний массив (удвоение).\r\nPop/Dequeue на пустой коллекции — бросать InvalidOperationException." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Console.WriteLine("--- MyStack<int> ---");
            MyStack<int> stack = new MyStack<int>();
            for (int i = 1; i <= 6; i++) stack.Push(i * 10);
            Console.WriteLine($"Count после 6 Push: {stack.Count}, IsEmpty: {stack.IsEmpty}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}, Pop: {stack.Pop()}");
            Console.WriteLine($"Count: {stack.Count}");
            while (!stack.IsEmpty) stack.Pop();
            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Pop на пустом стеке: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("--- MyQueue<string> ---");
            MyQueue<string> queue = new MyQueue<string>();
            foreach (string s in new[] { "a", "b", "c", "d", "e", "f" }) queue.Enqueue(s);
            Console.WriteLine($"Count после 6 Enqueue: {queue.Count}, IsEmpty: {queue.IsEmpty}");
            Console.WriteLine($"Peek: {queue.Peek()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}, Dequeue: {queue.Dequeue()}");
            queue.Enqueue("g");
            Console.WriteLine($"Count: {queue.Count}");
            Console.Write("Остаток очереди: ");
            while (!queue.IsEmpty) Console.Write(queue.Dequeue() + " ");
            Console.WriteLine();
            try
            {
                queue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Dequeue на пустой очереди: {ex.Message}");
            }

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
