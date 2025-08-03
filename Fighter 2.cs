namespace Task_9;

public class Fighter_2 : Fighter
{
    private int _attackCount;

    public Fighter_2() : base("Slayer", 80, 3, 20)
    {
        
    }
    
    public override void TakeDamage(int amount)
    {
        _health -= amount*2;
    }

    public override void DealDamageTo(Fighter fighter)
    {
        int dealtDamage = this._damage;
        if (_attackCount == 3)
        {
            fighter.TakeDamage(dealtDamage);
            fighter.TakeDamage(dealtDamage);
        }
        else
        {
            fighter.TakeDamage(dealtDamage);
        }
    }
}