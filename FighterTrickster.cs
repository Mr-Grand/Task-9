namespace Task_9;

public class FighterTrickster : Fighter
{
    private readonly double _chanceToDodge = 40;

    public FighterTrickster() : base("Trickster", 70, 0, 25)
    {
    }

    public override void TakeDamage(int amount)
    {
        if (!TryToDodge())
        {
            base.TakeDamage(amount);
        }
    }
    
    private bool TryToDodge()
    {
        double dodgeChanceTrigger = RandomClass.Random.NextDouble() * 100;
        if (dodgeChanceTrigger <= _chanceToDodge)
        {
            Health -= 0;
            Console.WriteLine($"{ClassName} увернулся!");
            return true;
        }
        else
        {
            return false;
        }
    }
}