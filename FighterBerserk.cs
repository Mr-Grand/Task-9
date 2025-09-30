namespace Task_9;

public class FighterBerserk : Fighter
{
    private int _rage = 0;
    private readonly int _maxRage = 30;
    private readonly int _skillHealthRestore = 35;

    public FighterBerserk() : base("Berserk", 100, 0, 30)
    {
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        _rage += Convert.ToInt32(Math.Round(amount * 0.5));
        TryToHealthFromRage();
    }

    private void TryToHealthFromRage()
    {
        if (_rage >= _maxRage && IsAlive)
        {
            int possibleRestoredHealth = Health + _skillHealthRestore;
            Health = Math.Min(MaximumHealth, possibleRestoredHealth);
            Console.WriteLine("Ярость была поглощена, здоровье частично восстановлено");
            _rage = 0;
        }
    }

    public override void RestoreAfterFight()
    {
        base.RestoreAfterFight();
        _rage = 0;
    }
}