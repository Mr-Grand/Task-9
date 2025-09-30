namespace Task_9;

public class FighterSlayer : Fighter
{
    private int _attackCount;

    public FighterSlayer() : base("Slayer", 80, 7, 25)
    {
    }

    public override void DealDamageTo(Fighter target)
    {
        base.DealDamageTo(target);
        _attackCount++;
        TryDoubleAttack(target);
    }

    private void TryDoubleAttack(Fighter target)
    {
        if (_attackCount == 3)
        {
            Console.WriteLine("У {this.ClassName} сработала двойная атака!");
            base.DealDamageTo(target);
            _attackCount = 0;
        }
    }

    public override void RestoreAfterFight()
    {
        _attackCount = 0;
        base.RestoreAfterFight();
    }
}