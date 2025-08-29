namespace Task_9;

class Program
{
    static void Main(string[] args)
    {
        Arena arena = new Arena();
        arena.SimulateXNumberOfFights(100);

        bool ifContinue = true;
        while (ifContinue)
        {
            Console.WriteLine("Добро пожаловать на арену! " +
                              "\n1) Выбрать бойцов" +
                              "\n2) Посмотреть статистику побед" +
                              "\n3) Выход из программы");

            ConsoleKey input = Console.ReadKey().Key;
            Console.WriteLine();

            bool switchContinue = true;
            while (switchContinue)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"В казарме есть {ArenaFighters.Fighters.Count} бойцов. Вот их классы:");
                        int i = 1;
                        foreach (Fighter fighter in ArenaFighters.Fighters)
                        {
                            Console.WriteLine($"| {i}-{fighter.ShowName()} | ");
                            i++;
                        }

                        Console.WriteLine("Кого выберете для дуэли?");
                        int chooseFirstFighter = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine();
                        arena.AddFighter(ArenaFighters.Fighters[chooseFirstFighter]);
                        Console.WriteLine($"Хороший выбор. Кто будет его оппонентом?");
                        int chooseSecondFighter = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine();
                        arena.AddFighter(ArenaFighters.Fighters[chooseSecondFighter]);

                        Console.WriteLine(
                            $"Сегодня сойдутся в битве {ArenaFighters.Fighters[chooseFirstFighter].ShowName()} и " +
                            $"{ArenaFighters.Fighters[chooseSecondFighter].ShowName()}!");
                        Console.WriteLine("Начинаем битву?" +
                                          "\n1) Да, начинаем" +
                                          "\n2) Нет, выйти в меню");

                        ConsoleKey inputIfStart = Console.ReadKey().Key;
                        Console.WriteLine();
                        if (inputIfStart == ConsoleKey.D1)
                        {
                            arena.StartFightOnArena();
                            arena.ShowFightResult();
                            switchContinue = false;
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Clear();
                            switchContinue = false;
                            break;
                        }
                    case ConsoleKey.D2:
                        foreach (Fighter fighter in ArenaFighters.Fighters)
                        {
                            fighter.ShowWinRate();
                        }

                        switchContinue = false;
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