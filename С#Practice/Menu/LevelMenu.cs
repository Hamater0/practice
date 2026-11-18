using C_Practice.Tasks.Level1;
using C_Practice.Tasks.Level2;
using C_Practice.Tasks.Level3;
using С_Practice.Tasks.Level1;
namespace С_Practice.Menu
{
    public class LevelMenu
    {
        public void ShowLevelOneMenu()
        {
            bool Menu = true;
            while (Menu)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 1: Базовый ---");
                Console.WriteLine("1. Hello, World + текущая дата ");
                Console.WriteLine("2. Переменные примитивных типов");
                Console.WriteLine("3. Калькулятор с делением на ноль");
                Console.WriteLine("4. Чётность числа (два способа)");
                Console.WriteLine("5. Таблица умножения 10×10");
                Console.WriteLine("6. Сумма цифр числа (строка + арифметика)");
                Console.WriteLine("7. Реверс строки без LINQ");
                Console.WriteLine("8. FizzBuzz 1–100");
                Console.WriteLine("9. Массивы: min/max/sum/avg");
                Console.WriteLine("10. Сортировка пузырьком + вставками");
                Console.WriteLine("11. Диагональ матрицы N×N");
                Console.WriteLine("12. Палиндром (без учёта регистра/пробелов)");
                Console.WriteLine("13. Счётчик вхождений слов в тексте ");
                Console.WriteLine("14. Возраст по дате рождения");

                Console.WriteLine("16. Назад");
                Console.Write("Выберите задание");
                string TaskInput = Console.ReadLine();
                switch (TaskInput)
                {
                    case "1":

                        Task01_HelloWorld task = new Task01_HelloWorld();
                        task.Run();
                        break;
                    case "2":

                        Task02_Peremen task2 = new Task02_Peremen();
                        task2.Run();
                        break;
                    case "3":
                        Task03_Calculator task3 = new Task03_Calculator();
                        task3.Run();
                        break;
                    case "4":
                        Task04_Parity task4 = new Task04_Parity();
                        task4.Run();
                        task4.Run2();
                        break;
                    case "5":
                        Task05_table task5 = new Task05_table();
                        task5.Run();
                        break;
                    case "6":
                        Task06_Summa task6 = new Task06_Summa();
                        task6.Run();
                        task6.Run2();
                        break;
                    case "7":
                        Task07_Revers task7 = new Task07_Revers();
                        task7.Run();
                        break;
                    case "8":
                        Task08__FizzBuzz task8 = new Task08__FizzBuzz();
                        task8.Run();
                        break;
                    case "9":
                        Task09_Array task9 = new Task09_Array();
                        task9.Run();
                        break;
                    case "10":
                        Task10_Sort task10 = new Task10_Sort();
                        task10.Run();
                        break;
                    case "11":
                        Task11_Diagonal task11 = new Task11_Diagonal();
                        task11.Run();
                        break;
                    case "12":
                        Task12_Palindrome task12 = new Task12_Palindrome();
                        task12.Run();
                        break;
                    case "13":
                        Task13_Counter task13 = new Task13_Counter();
                        task13.Run();
                        break;
                    case "14":
                        Task14_Age task14 = new Task14_Age();
                        task14.Run();
                        break;

                    case "16":
                        MenuRunner runner = new MenuRunner();
                        runner.Start();
                        break;

                }

            }
        }
        public void ShowLevelTwoMenu()
        {
            bool Menu = true;
            while (Menu)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 2: Средний ---");
                Console.WriteLine("16. Методы расширения для string");
                Console.WriteLine("17. StringBuilder vs конкатенация (замер)");
                Console.WriteLine("18. TryParse vs try/catch");
                Console.WriteLine("19. Свой стек/очередь на массиве");
                Console.WriteLine("20. Обобщения: Swap<T>, Max<T> с IComparable<T>");
                Console.WriteLine("21. enum дни недели");
                Console.WriteLine("22. params-метод + перегрузка");
                Console.WriteLine("23. Nullable-типы, ??, ?.");
                Console.WriteLine("24. ООП: Animal → Dog/Cat/Bird");
                Console.WriteLine("25. Интерфейс IShape + сортировка фигур");
                Console.WriteLine("26. Паттерн «Стратегия» (скидки)");
                Console.WriteLine("27. IComparable / IComparer<T> для Student");
                Console.WriteLine("28. Equals / GetHashCode для Point");
                Console.WriteLine("29. Паттерн «Фабрика» (уведомления)");
                Console.WriteLine("30. BankAccount + свой Exception");
                Console.WriteLine("31. IDisposable + using");
                Console.WriteLine("32. Свойства с валидацией (Temperature)");
                Console.WriteLine("33. LINQ: сотрудники (top-3, avg по отделу, фильтр)");
                Console.WriteLine("34. LINQ: группировка слов по первой букве");
                Console.WriteLine("35. Git: .gitignore, .editorconfig, PR, rebase");

                Console.WriteLine("36. Назад");
                Console.Write("Выберите задание");
                string TaskInput = Console.ReadLine();
                switch (TaskInput)
                {
                    case "16":
                        Task16_StringExtensions task16 = new Task16_StringExtensions();
                        task16.Run();
                        break;
                    case "17":
                        Task17_StringBuilderVsConcat task17 = new Task17_StringBuilderVsConcat();
                        task17.Run();
                        break;
                    case "18":
                        Task18_TryParseVsTryCatch task18 = new Task18_TryParseVsTryCatch();
                        task18.Run();
                        break;
                    case "19":
                        Task19_MyStackQueue task19 = new Task19_MyStackQueue();
                        task19.Run();
                        break;
                    case "20":
                        Task20_Generics task20 = new Task20_Generics();
                        task20.Run();
                        break;
                    case "21":
                        Task21_EnumDays task21 = new Task21_EnumDays();
                        task21.Run();
                        break;
                    case "22":
                        Task22_ParamsSum task22 = new Task22_ParamsSum();
                        task22.Run();
                        break;
                    case "23":
                        Task23_Nullable task23 = new Task23_Nullable();
                        task23.Run();
                        break;
                    case "24":
                        Task24_Animals task24 = new Task24_Animals();
                        task24.Run();
                        break;
                    case "25":
                        Task25_Shapes task25 = new Task25_Shapes();
                        task25.Run();
                        break;
                    case "26":
                        Task26_DiscountStrategy task26 = new Task26_DiscountStrategy();
                        task26.Run();
                        break;
                    case "27":
                        Task27_StudentSorting task27 = new Task27_StudentSorting();
                        task27.Run();
                        break;
                    case "28":
                        Task28_PointEquals task28 = new Task28_PointEquals();
                        task28.Run();
                        break;
                    case "29":
                        Task29_NotificationFactory task29 = new Task29_NotificationFactory();
                        task29.Run();
                        break;
                    case "30":
                        Task30_BankAccount task30 = new Task30_BankAccount();
                        task30.Run();
                        break;
                    case "31":
                        Task31_Disposable task31 = new Task31_Disposable();
                        task31.Run();
                        break;
                    case "32":
                        Task32_Temperature task32 = new Task32_Temperature();
                        task32.Run();
                        break;
                    case "33":
                        Task33_LinqEmployees task33 = new Task33_LinqEmployees();
                        task33.Run();
                        break;
                    case "34":
                        Task34_LinqGroupWords task34 = new Task34_LinqGroupWords();
                        task34.Run();
                        break;
                    case "35":
                        Task35_GitScenario task35 = new Task35_GitScenario();
                        task35.Run();
                        break;

                    case "36":
                        MenuRunner runner = new MenuRunner();
                        runner.Start();
                        break;

                }
            }
        }
        public void ShowLevelThreeMenu()
        {
            bool Menu = true;
            while (Menu)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 3: Продвинутый ---");
                Console.WriteLine("36. Дубликаты в List (HashSet + GroupBy)");
                Console.WriteLine("37. Мемоизация Фибоначчи через Dictionary");
                Console.WriteLine("38. List<T> vs LinkedList<T> (бенчмарк)");
                Console.WriteLine("39. yield return — генератор чётных чисел");
                Console.WriteLine("40. async/await + обработка исключений");
                Console.WriteLine("41. Task.WhenAll — параллельно 10 задач");
                Console.WriteLine("42. CancellationToken — отмена через 2 сек");
                Console.WriteLine("43. Множественные типы исключений, порядок catch");
                Console.WriteLine("44. Мини-проект «Todo List» (классы + JSON)");
                Console.WriteLine("45. Мини-проект «Библиотека» + юнит-тесты");
                Console.WriteLine("46. Git: git stash / stash pop");
                Console.WriteLine("47. Git: rebase -i (сквош коммитов)");
                Console.WriteLine("48. Git: теги (v1.0.0)");
                Console.WriteLine("49. Git: восстановление через reflog");
                Console.WriteLine("50. Git: симуляция bisect");

                Console.WriteLine("51. Назад");
                Console.Write("Выберите задание");
                string TaskInput = Console.ReadLine();
                switch (TaskInput)
                {
                    case "36":
                        Task36_Duplicates task36 = new Task36_Duplicates();
                        task36.Run();
                        break;
                    case "37":
                        Task37_FibonacciMemo task37 = new Task37_FibonacciMemo();
                        task37.Run();
                        break;
                    case "38":
                        Task38_ListVsLinkedList task38 = new Task38_ListVsLinkedList();
                        task38.Run();
                        break;
                    case "39":
                        Task39_YieldEven task39 = new Task39_YieldEven();
                        task39.Run();
                        break;
                    case "40":
                        Task40_AsyncAwait task40 = new Task40_AsyncAwait();
                        task40.Run();
                        break;
                    case "41":
                        Task41_WhenAll task41 = new Task41_WhenAll();
                        task41.Run();
                        break;
                    case "42":
                        Task42_CancellationToken task42 = new Task42_CancellationToken();
                        task42.Run();
                        break;
                    case "43":
                        Task43_CatchOrder task43 = new Task43_CatchOrder();
                        task43.Run();
                        break;
                    case "44":
                        Task44_TodoList task44 = new Task44_TodoList();
                        task44.Run();
                        break;
                    case "45":
                        Task45_Library task45 = new Task45_Library();
                        task45.Run();
                        break;
                    case "46":
                        Task46_GitStash task46 = new Task46_GitStash();
                        task46.Run();
                        break;
                    case "47":
                        Task47_GitSquash task47 = new Task47_GitSquash();
                        task47.Run();
                        break;
                    case "48":
                        Task48_GitTags task48 = new Task48_GitTags();
                        task48.Run();
                        break;
                    case "49":
                        Task49_GitReflog task49 = new Task49_GitReflog();
                        task49.Run();
                        break;
                    case "50":
                        Task50_GitBisect task50 = new Task50_GitBisect();
                        task50.Run();
                        break;

                    case "51":
                        MenuRunner runner = new MenuRunner();
                        runner.Start();
                        break;

                }
            }
        }
    }
}
