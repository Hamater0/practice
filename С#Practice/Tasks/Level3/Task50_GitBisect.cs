using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level3
{
    public class Task50_GitBisect : ITask
    {
        public string Title => "==================================================\r\nЗадание 50. Git: симуляция bisect (поиск «плохого» коммита)\r\n--------------------------------------------------";
        public string Description => "Описание: найти «плохой» коммит через git bisect. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\n1. Репозиторий с 10+ коммитами.\r\n2. В одном из средних коммитов намеренно «сломать» функцию.\r\n3. Запустить git bisect start.\r\n4. Пометить git bisect bad (текущий) и git bisect good <hash> (первый рабочий).\r\n5. Пройти бисекцию: на каждом шаге git bisect good / git bisect bad.\r\n6. Найти «плохой» коммит, показать вывод.\r\n7. Завершить: git bisect reset.\r\n8. Сохранить вывод в git-notes.md." };

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(string.Join("\n", Requirements));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            Console.WriteLine("Команды для выполнения:");
            Console.WriteLine(@"
# 1-2. 10 коммитов, в 6-м «ломаем» файл (строка BROKEN)
git checkout -b feature/bisect-demo

echo good 1 > bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 1""
echo good 2 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 2""
echo good 3 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 3""
echo good 4 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 4""
echo good 5 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 5""
echo BROKEN >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 6""
echo good 7 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 7""
echo good 8 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 8""
echo good 9 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 9""
echo good 10 >> bisect-demo.txt
git add bisect-demo.txt
git commit -m ""feat: step 10""

git log --oneline

# 3-4. начать бисекцию: текущий коммит плохой, первый коммит (step 1) хороший
git bisect start
git bisect bad
git bisect good <хеш коммита ""feat: step 1"">

# 5. на каждом шаге посмотрите файл (cat bisect-demo.txt или type bisect-demo.txt):
#    есть слово BROKEN -> git bisect bad, нет -> git bisect good
git bisect good
git bisect bad

# 6. git сообщит: <хеш> is the first bad commit (это коммит ""feat: step 6"")
#    скопируйте весь вывод бисекции в git-notes.md

# 7. завершить
git bisect reset
");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
