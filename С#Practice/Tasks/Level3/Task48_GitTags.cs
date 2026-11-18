using System;
using С_Practice.Common;

namespace C_Practice.Tasks.Level3
{
    public class Task48_GitTags : ITask
    {
        public string Title => "==================================================\r\nЗадание 48. Git: теги (v1.0.0)\r\n--------------------------------------------------";
        public string Description => "Описание: поставить аннотированный тег. ";
        public string[] Requirements => new string[] { "Требования:\r\n\r\n1. На стабильный коммит в main поставить тег: git tag -a v1.0.0 -m \"Release v1.0.0\".\r\n2. Запушить тег: git push origin v1.0.0.\r\n3. Показать git tag и git show v1.0.0.\r\n4. Сохранить вывод в git-notes.md." };

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
# 1. убедитесь, что вы на стабильном коммите в main
git checkout main
git pull

# аннотированный тег
git tag -a v1.0.0 -m ""Release v1.0.0""

# 2. отправить тег на удалённый репозиторий
git push origin v1.0.0

# 3. показать (скопируйте вывод в git-notes.md)
git tag
git show v1.0.0

# проверка на удалённом репозитории: раздел Tags / Releases на GitHub
");

            Console.WriteLine("\nНажмите Enter для возврата...");
            Console.ReadLine();
        }
    }
}
