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
                        ShowAllFightersAndChooseTwoOfThem(arena);
                        
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
                        Console.WriteLine();

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

    public static void ShowAllFightersAndChooseTwoOfThem(Arena arena)
    {
        Console.WriteLine($"В казарме есть {ArenaFighters.Fighters.Count} бойцов. Вот их классы:");
        int i = 1;
        foreach (Fighter fighter in ArenaFighters.Fighters)
        {
            Console.WriteLine($"| {i}-{fighter.ShowName()} | ");
            i++;
        }

        Console.WriteLine("Кого выберете для дуэли?");
        ChooseFighterForArena(arena);
        Console.WriteLine($"\nХороший выбор. Кто будет его оппонентом?");
        ChooseFighterForArena(arena);
        
        ShowFightersOnArena(arena);
    }

    public static void ChooseFighterForArena(Arena arena)
    {
        bool fighterCorrectInputCheck = true;
        while (fighterCorrectInputCheck)
        {
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (!arena.GetFighters().Contains(ArenaFighters.Fighters[input - 1]))
                {
                    arena.AddFighter(ArenaFighters.Fighters[input-1]);
                    fighterCorrectInputCheck = false;
                }
                else
                {
                    Console.WriteLine("Этот воин уже участвует, выберите другого");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, повторите попытку");
            }
        }
    }

    public static void ShowFightersOnArena(Arena arena)
    {
        IReadOnlyList<Fighter> fightersOnArena = new List<Fighter>();
        fightersOnArena = arena.GetFighters();
        Console.WriteLine($"Сегодня дерутся {fightersOnArena[0].ShowName()} и {fightersOnArena[1].ShowName()}!");
    }
}