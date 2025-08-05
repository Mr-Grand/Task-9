namespace Task_9;

public class Fighter2 : Fighter
{
    private int _attackCount;

    public Fighter2() : base("Slayer", 80, 3, 20)
    {
        
    }

    public override void DealDamageTo(Fighter fighter)
    {
        if (_attackCount == 3)
        {
            Console.WriteLine("Произошла двойная атака!");
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
}