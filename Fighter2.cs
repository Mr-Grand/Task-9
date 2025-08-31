namespace Task_9;

public class Fighter2 : Fighter
{
    private int _attackCount;

    public Fighter2() : base("Slayer", 80, 7, 25)
    {
    }

    public override void DealDamageTo(Fighter fighter)
    {
        if (_attackCount == 2)
        {
            Console.WriteLine($"У {this.ClassName} сработала двойная атака!");
            base.DealDamageTo(fighter);
            base.DealDamageTo(fighter);
            _attackCount = 0;
        }
        else
        {
            base.DealDamageTo(fighter);
            _attackCount++;
        }
    }

    public override void RestoreAfterFight()
    {
        _attackCount = 0;
        base.RestoreAfterFight();
    }
}