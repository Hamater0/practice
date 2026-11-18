using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level2
{
    public class Task35_GitScenario : ITask
    {
        public string Title => "==================================================\r\nЗадание 35. Git: .gitignore, .editorconfig, PR, Conventional Commits, rebase\r\n--------------------------------------------------";
        public string Description => "Описание: пройти продвинутый git-сценарий. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\n1. Добавить .gitignore (bin/, obj/, .vs/, *.user) и .editorconfig отдельным коммитом «chore: add gitignore and editorconfig».\r\n2. Создать ветку feature/task-35, сделать 2–3 коммита по Conventional Commits.\r\n3. Запушить ветку на GitHub/GitLab.\r\n4. Открыть Pull Request в main с описанием: что сделано, что проверял.\r\n5. Смержить PR (можно squash-merge).\r\n6. Создать ветку feature/rebase-demo, 3 маленьких коммита.\r\n7. Объединить их через git rebase -i HEAD~3 (squash).\r\n8. Сохранить вывод git log --oneline после rebase в git-notes.md." };

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
# 1. gitignore + editorconfig
git add .gitignore .editorconfig
git commit -m ""chore: add gitignore and editorconfig""

# 2. ветка и коммиты
git checkout -b feature/task-35
git add .
git commit -m ""feat: add level 2 tasks 16-20""
git commit -m ""feat: add level 2 tasks 21-35""
git commit -m ""docs: add git notes""

# 3. push
git push -u origin feature/task-35

# 4-5. Pull Request в main на GitHub/GitLab, затем squash-merge
git checkout main
git pull

# 6. rebase-demo
git checkout -b feature/rebase-demo
git commit --allow-empty -m ""wip: step 1""
git commit --allow-empty -m ""wip: step 2""
git commit --allow-empty -m ""wip: step 3""

# 7. squash: в редакторе оставить pick у первого, у остальных заменить pick на squash (s)
git rebase -i HEAD~3

# 8. сохранить лог
git log --oneline > git-notes.md
");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
