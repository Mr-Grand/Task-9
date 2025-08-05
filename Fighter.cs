namespace Task_9;

public class Fighter
{
    protected string ClassName;
    protected int MaximumHealth;
    protected int Health;
    protected int Armour;
    protected int Damage;
    protected int WinCount;
    protected int FightCount;

    public Fighter(string fighterClass, int health, int armour, int damage)
    {
        ClassName = fighterClass;
        MaximumHealth = health;
        Health = MaximumHealth;
        Armour = armour;
        Damage = damage;
    }

    public void ShowFighterInfo()
    {
        Console.WriteLine($"Class: {ClassName}" +
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
        Console.WriteLine($"{this.ClassName} атакует");
        fighter.TakeDamage(dealtDamage);
    }

    public virtual void RestoreAfterFight()
    {
        Health = MaximumHealth;
    }

    public void AddWinToCount()
    {
        WinCount++;
    }

    public void ShowWinRate()
    {
        Console.WriteLine($"{ClassName} win rate is {WinCount/FightCount*100}");
    }

    public string ShowName()
    {
        return ClassName;
    }

    public int CheckHealth()
    {
        return Health;
    }
}