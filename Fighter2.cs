namespace Task_9;

public class Fighter2 : Fighter
{
    private int _attackCount;

    public Fighter2() : base("Slayer", 80, 3, 20)
    {
        
    }

    public override void DealDamageTo(Fighter fighter)
    {
        int dealtDamage = this.Damage;
        if (_attackCount == 3)
        {
            fighter.TakeDamage(dealtDamage);
            fighter.TakeDamage(dealtDamage);
            _attackCount = 0;
        }
        else
        {
            fighter.TakeDamage(dealtDamage);
            _attackCount++;
        }
       
    }
}