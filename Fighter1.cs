namespace Task_9;

public class Fighter1 : Fighter
{
    private readonly double _critChance = 40;
    private readonly double _critMulti = 50;

    public Fighter1() : base("Warrior", 100, 10, 20)
    {
    }

    public override void DealDamageTo(Fighter fighter)
    {
        int dealtDamage = 0;
        double ifCrit = RandomClass.Random.NextDouble();
        if (ifCrit <= _critChance / 100)
        {
            dealtDamage = Convert.ToInt32(this.Damage * (1 + _critMulti / 100));
            fighter.TakeDamage(dealtDamage);
            Console.WriteLine($"{this.ClassName} атакует и наносит крит!");
        }
        else
        {
            base.DealDamageTo(fighter);
        }
    }
}