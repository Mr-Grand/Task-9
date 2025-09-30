namespace Task_9;

public class FighterWarrior : Fighter
{
    private readonly double _critChance = 40;
    private readonly double _critMulti = 50;

    public FighterWarrior() : base("Warrior", 100, 10, 20)
    {
    }

    public override void DealDamageTo(Fighter target)
    {
        if (!TryToCriticalHit(target))
        {
            base.DealDamageTo(target);
        }
    }

    private bool TryToCriticalHit(Fighter target)
    {
        double ifCrit = RandomClass.Random.NextDouble();
        if (ifCrit <= _critChance / 100)
        {
            int dealtDamage = Convert.ToInt32(Damage * (1 + _critMulti / 100));
            target.TakeDamage(dealtDamage);
            Console.WriteLine($"{ClassName} нанес крит!");
            return true;
        }
        else
        {
            return false;
        }
    }
}