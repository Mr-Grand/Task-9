namespace Task_9;

public class Arena
{
    private List<Fighter> _fightersOnArena = new();

    public void AddFighter(Fighter fighter)
    {
        _fightersOnArena.Add(fighter);
    }

    public void StartFightOnArena()
    {
        while (_fightersOnArena[0].CheckHealth() > 0 && _fightersOnArena[1].CheckHealth() > 0)
        {
            _fightersOnArena[0].DealDamageTo(_fightersOnArena[1]);
            if (_fightersOnArena[1].CheckHealth() > 0)
            {
                _fightersOnArena[1].DealDamageTo(_fightersOnArena[0]);
            }
        }
        _fightersOnArena[0].AddBattleToCount();
        _fightersOnArena[1].AddBattleToCount();
    }

    public void ShowFightResult()
    {
        if (_fightersOnArena[0].CheckHealth() <= 0)
        {
            Console.WriteLine($"Победил {_fightersOnArena[1].ShowName()}!");
            _fightersOnArena[1].AddWinToCount();
            EndFightOnArena();
        }
        else if (_fightersOnArena[1].CheckHealth() <= 0)
        {
            Console.WriteLine($"Победил {_fightersOnArena[0].ShowName()}!");
            _fightersOnArena[0].AddWinToCount();
            EndFightOnArena();
        }
    }

    public void EndFightOnArena()
    {
        foreach (var fighter in _fightersOnArena)
        {
            fighter.RestoreAfterFight();
        }

        _fightersOnArena.Clear();
    }

    public void SimulateXNumberOfFights(int x)
    {
        for (int i = 0; i < x; i++)
        {
            AddFighter(ArenaFighters.Fighters[RandomClass.Random.Next(ArenaFighters.Fighters.Count)]);
            AddFighter(ArenaFighters.Fighters[RandomClass.Random.Next(ArenaFighters.Fighters.Count)]);
            StartFightOnArena();
            ShowFightResult();
            EndFightOnArena();
        }

        /*Console.SetCursorPosition(0,0);
        Console.Clear();*/
        Console.Write("\f\u001bc\x1B[3J"); // Console.Clear не чистит всю консоль
        Console.WriteLine(new string('-', 50));
    }
}