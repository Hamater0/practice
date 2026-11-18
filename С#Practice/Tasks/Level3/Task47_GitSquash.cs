using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level3
{
    public class Task47_GitSquash : ITask
    {
        public string Title => "==================================================\r\nЗадание 47. Git: rebase -i (сквош коммитов)\r\n--------------------------------------------------";
        public string Description => "Описание: объединить несколько коммитов в один. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\n1. Создать ветку feature/squash-demo.\r\n2. Сделать 4 маленьких коммита.\r\n3. Выполнить git rebase -i HEAD~4, объединить в один (squash).\r\n4. Показать git log --oneline до и после.\r\n5. Сохранить оба вывода в git-notes.md." };

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
# 1. ветка
git checkout -b feature/squash-demo

# 2. четыре маленьких коммита
git commit --allow-empty -m ""wip: squash step 1""
git commit --allow-empty -m ""wip: squash step 2""
git commit --allow-empty -m ""wip: squash step 3""
git commit --allow-empty -m ""wip: squash step 4""

# 4. лог ДО (скопируйте в git-notes.md)
git log --oneline

# 3. сквош: в редакторе оставьте pick у первого коммита, у остальных трёх замените pick на squash (или s),
#    затем сохраните, в следующем окне задайте общее сообщение, например ""feat: squash demo""
git rebase -i HEAD~4

# 4. лог ПОСЛЕ (скопируйте в git-notes.md)
git log --oneline
");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
