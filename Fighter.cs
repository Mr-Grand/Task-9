namespace Task_9;

public class Fighter
{
    protected string _class;
    protected int _health;
    protected int _armour;
    protected int _damage;

    public Fighter(string fighterClass, int health, int armour, int damage)
    {
        _class = fighterClass;
        _health = health;
        _armour = armour;
        _damage = damage;
    }

    public void ShowFighterInfo()
    {
        Console.WriteLine($"Class: {_class}" +
                          $"\nHealth - {_health}" +
                          $"\nArmour - {_armour}" +
                          $"\nDamage - {_damage}");
    }

    public virtual void TakeDamage(int amount)
    {
        _health -= amount;
    }

    public virtual void DealDamageTo(Fighter fighter)
    {
        int dealtDamage = this._damage;
        fighter.TakeDamage(dealtDamage);
    }
}