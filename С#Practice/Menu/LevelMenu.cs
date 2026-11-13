using C_Practice.Tasks.Level1;
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
        }
    }


    

