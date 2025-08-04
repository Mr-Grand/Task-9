namespace Task_9;

public class Fighter3 : Fighter
{
    private int _rage = 0;
    private int _maxRage = 30;
    private int _skillHealthRestore = 35;

    public Fighter3() : base("Berserk", 100, 0, 30)
    {
        
    }

    public override void TakeDamage(int amount)
    {
        if (_rage >= _maxRage)
        {
            base.TakeDamage(amount);
            Health += _skillHealthRestore;
            _rage = 0;
        }
        else
        {
            base.TakeDamage(amount);
            _rage += Convert.ToInt32(Math.Round(amount * 0.5));
        }
    }

    public override void RestoreAfterFight()
    {
        base.RestoreAfterFight();
        _rage = 0;
    }
}