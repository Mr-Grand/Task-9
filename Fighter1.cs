namespace Task_9;

public class Fighter1 : Fighter
{
    private int _critChance = 40;
    private int _critMulti = 50;

    public Fighter1() : base("Warrior", 100, 10, 20)
    {
        
    }

    public override void DealDamageTo(Fighter fighter)
    {
        int dealtDamage = 0;
        double ifCrit = RandomClass.Random.NextDouble();
        if (ifCrit <= _critChance)
        {
            dealtDamage = this.Damage * (1 + _critMulti/100);
        }
        else
        {
            dealtDamage = this.Damage;
        }
        fighter.TakeDamage(dealtDamage);
    }
}