namespace Task_9;

public class Arena
{
    private List<Fighter> _fighters = new();

    public void AddFighter(Fighter fighter)
    {
        _fighters.Add(fighter);
    }

    public void StartFightOnArena()
    {
        while (_fighters[0].IsAlive && _fighters[1].IsAlive)
        {
            Console.WriteLine(new string('-', 25));
            _fighters[0].DealDamageTo(_fighters[1]);
            if (_fighters[1].IsAlive)
            {
                _fighters[1].DealDamageTo(_fighters[0]);
            }
        }
        _fighters[0].AddBattleToCount();
        _fighters[1].AddBattleToCount();
    }

    public void ShowFightResult()
    {
        if (!_fighters[0].IsAlive)
        {
            Console.WriteLine($"Победил {_fighters[1].ShowName()}!");
            _fighters[1].AddWinToCount();
            EndFightOnArena();
        }
        else if (!_fighters[1].IsAlive)
        {
            Console.WriteLine($"Победил {_fighters[0].ShowName()}!");
            _fighters[0].AddWinToCount();
            EndFightOnArena();
        }
    }

    public void EndFightOnArena()
    {
        foreach (var fighter in _fighters)
        {
            fighter.RestoreAfterFight();
        }

        _fighters.Clear();
    }

    public void SimulateXNumberOfFights(int x)
    {
        for (int i = 0; i < x; i++)
        {
            AddFighter(ArenaFighters.Fighters[RandomClass.Random.Next(ArenaFighters.Fighters.Count)]);
            AddFighter(ArenaFighters.Fighters[RandomClass.Random.Next(ArenaFighters.Fighters.Count)]);
            StartFightOnArena();
            ShowFightResult();
        }
        /*Console.SetCursorPosition(0,0);
        Console.Clear();*/
        Console.Write("\f\u001bc\x1B[3J"); // Console.Clear не чистит всю консоль
        Console.WriteLine(new string('-', 50));
    }

    public IReadOnlyList<Fighter> GetFighters()
    {
        return _fighters;
    }
}