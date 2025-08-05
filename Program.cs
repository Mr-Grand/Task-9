namespace Task_9;

class Program
{
    static void Main(string[] args)
    {
        Arena arena = new Arena();
        bool ifContinue = true;
        while (ifContinue)
        {
            Console.WriteLine("Добро пожаловать на арену! " +
                              "Здесь можно выбрать двух бойцов и провести спаринг между ними" +
                              "\n1) Выбрать бойцов" +
                              "\n2) Посмотреть статистику побед" +
                              "\n3) Выход из программы");

            ConsoleKey input = Console.ReadKey().Key;
            
            bool switchContinue = true;
            while (switchContinue)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"В казарме есть {ArenaFighters.Fighters.Count} бойцов. Вот их классы:");
                        int i = 0;
                        foreach (Fighter fighter in ArenaFighters.Fighters)
                        {
                            Console.WriteLine($"| {i}{fighter.ShowName()} | ");
                            i++;
                        }

                        Console.WriteLine("Кого выберете для дуэли?");
                        int chooseFirstFighter = Convert.ToInt32(Console.ReadLine());
                        arena.AddFighter(ArenaFighters.Fighters[chooseFirstFighter]);
                        Console.WriteLine($"Хороший выбор. Кто будет его оппонентом?");
                        int chooseSecondFighter = Convert.ToInt32(Console.ReadLine());
                        arena.AddFighter(ArenaFighters.Fighters[chooseSecondFighter]);

                        Console.WriteLine($"Сегодня сойдутся в битве {ArenaFighters.Fighters[chooseFirstFighter]} и " +
                                          $"{ArenaFighters.Fighters[chooseFirstFighter]}!");
                        Console.WriteLine("Начинаем битву?" +
                                          "\n1) Да, начинаем" +
                                          "\n2) Нет, выйти в меню");
                        
                        ConsoleKey inputIfStart = Console.ReadKey().Key;
                        if (inputIfStart == ConsoleKey.D1)
                        {
                            arena.StartFightOnArena();
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(0,0);
                            Console.Clear();
                            break;
                        }
                        
                        
                        
                        break;
                    case ConsoleKey.D2:
                        foreach (Fighter fighter in ArenaFighters.Fighters)
                        {
                            fighter.ShowWinRate();
                        }
                        break;
                    case ConsoleKey.D3:
                        switchContinue = false;
                        ifContinue = false;
                        break;
                }
            }
        }
    }
}