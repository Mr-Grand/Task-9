namespace Task_9;

public class Fighter
{
    protected string Class;
    protected int MaxHealth;
    protected int Health;
    protected int Armour;
    protected int Damage;

    public Fighter(string fighterClass, int health, int armour, int damage)
    {
        Class = fighterClass;
        MaxHealth = health;
        Health = MaxHealth;
        Armour = armour;
        Damage = damage;
    }

    public void ShowFighterInfo()
    {
        Console.WriteLine($"Class: {Class}" +
                          $"\nHealth - {Health}" +
                          $"\nArmour - {Armour}" +
                          $"\nDamage - {Damage}");
    }

    public virtual void TakeDamage(int amount)
    {
        Health -= (amount - Armour);
    }

    public virtual void DealDamageTo(Fighter fighter)
    {
        int dealtDamage;
        dealtDamage = this.Damage;
        fighter.TakeDamage(dealtDamage);
    }

    public virtual void RestoreAfterFight()
    {
        Health = MaxHealth;
    }
}