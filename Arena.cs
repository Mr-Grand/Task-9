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
        while (_fightersOnArena[0].CheckHealth() != 0 || _fightersOnArena[1].CheckHealth() != 0)
        {
            _fightersOnArena[0].DealDamageTo(_fightersOnArena[1]);
            _fightersOnArena[1].DealDamageTo(_fightersOnArena[0]);
        }
    }
}