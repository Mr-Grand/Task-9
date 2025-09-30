namespace Task_9;

public class FighterMage : Fighter
{
    private readonly int _maximumMana = 100;
    private int _mana = 100;

    private List<Spell> _spells = new()
    {
        new Spell("Fireball", 45, 40)
    };

    public FighterMage() : base("Mage", 70, 5, 10)
    {
    }

    public override void DealDamageTo(Fighter target)
    {
        if (!TryToCastMagicalSpell(target))
        {
            base.DealDamageTo(target);
        }
    }

    private bool TryToCastMagicalSpell(Fighter target)
    {
        if (_mana >= _spells[0].GetSpellManaCost())
        {
            int dealtDamage = _spells[0].GetSpellDamage();
            Console.WriteLine($"Было использовано заклинание {_spells[0].GetSpellName()}!");
            target.TakeDamage(dealtDamage);
            _mana -= _spells[0].GetSpellManaCost();
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RestoreAfterFight()
    {
        base.RestoreAfterFight();
        _mana = _maximumMana;
    }
}