namespace Task_9;

public class Fighter
{
    protected int MaximumHealth;
    protected int Armour;
    protected int Damage;
    protected int WinCount;
    protected int FightCount;
    
    public int Health { get; protected set; }
    public bool IsAlive {get => Health > 0;}
    protected string ClassName { get; }
    
    public Fighter(string fighterClass, int health, int armour, int damage)
    {
        ClassName = fighterClass;
        MaximumHealth = health;
        Health = MaximumHealth;
        Armour = armour;
        Damage = damage;
    }

    public virtual void TakeDamage(int amount)
    {
        if (amount > Armour)
        {
            Health -= (amount - Armour);
        }
    }

    public virtual void DealDamageTo(Fighter fighter)
    {
        Console.WriteLine($"{this.ClassName} атакует");
        fighter.TakeDamage(Damage);
    }

    public virtual void RestoreAfterFight()
    {
        Health = MaximumHealth;
    }

    public void AddWinToCount()
    {
        WinCount++;
    }

    public void AddBattleToCount()
    {
        FightCount++;
    }

    public void ShowWinRate()
    {
        if (this.FightCount == 0)
        {
            Console.WriteLine($"{this.ClassName} win rate is 0 | F{this.FightCount}/W{this.WinCount}");
        }
        else
        {
            double winRatePercentage = WinCount / Convert.ToDouble(FightCount) * 100;
            Console.WriteLine($"{this.ClassName} win rate is {Math.Round(winRatePercentage)}% | " +
                              $"{this.FightCount} fights / {this.WinCount} wins");
        }
    }

    public string ShowName()
    {
        return ClassName;
    }
}