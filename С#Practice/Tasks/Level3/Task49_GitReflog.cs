using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level3
{
    public class Task49_GitReflog : ITask
    {
        public string Title => "==================================================\r\nЗадание 49. Git: восстановление через reflog\r\n--------------------------------------------------";
        public string Description => "Описание: удалить коммит и восстановить его. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\n1. Сделать коммит.\r\n2. Удалить его: git reset --hard HEAD~1.\r\n3. Найти хеш через git reflog.\r\n4. Восстановить: git reset --hard <hash>.\r\n5. Показать git reflog и git log --oneline.\r\n6. Сохранить вывод в git-notes.md." };

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
# 1. сделать коммит
echo reflog demo > reflog-demo.txt
git add reflog-demo.txt
git commit -m ""feat: add reflog demo""
git log --oneline

# 2. удалить его
git reset --hard HEAD~1

# 3. найти хеш удалённого коммита (строка с ""feat: add reflog demo"")
git reflog

# 4. восстановить (подставьте найденный хеш вместо <hash>)
git reset --hard <hash>

# 5. показать результат (скопируйте вывод в git-notes.md)
git reflog
git log --oneline
");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
