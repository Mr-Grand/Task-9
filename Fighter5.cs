namespace Task_9;

public class Fighter5 : Fighter
{
    private double _chanceToDodge = 40;

    public Fighter5() : base("Trickster", 70, 0, 25)
    {
    }

    public override void TakeDamage(int amount)
    {
        double dodgeChanceTrigger = RandomClass.Random.NextDouble() * 100;
        if (dodgeChanceTrigger <= _chanceToDodge)
        {
            Health -= 0;
            Console.WriteLine($"{ClassName} увернулся!");
        }
        else
        {
            base.TakeDamage(amount);
        }
    }
}