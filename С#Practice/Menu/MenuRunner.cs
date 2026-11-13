using System;
using System.Collections.Generic;
using System.Text;

namespace С_Practice.Menu
{
    public class MenuRunner
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("=== Практикум по C# ===");
            Console.WriteLine("1. Уровень 1 — Базовый (задания 1–15)");
            Console.WriteLine("2. Уровень 2 — Средний (задания 16–35)");
            Console.WriteLine("3. Уровень 3 — Продвинутый (задания 36–50)");
            Console.WriteLine("4. Выход");
            Console.WriteLine();
            Console.Write("Выберите уровень:");
            string userInpit = Console.ReadLine();

            switch (userInpit)
            {
                case "1":
                    LevelMenu levelMenu = new LevelMenu();
                    levelMenu.ShowLevelOneMenu();
                    break;
            }
        }
    }
}
