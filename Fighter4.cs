namespace Task_9;

public class Fighter4 : Fighter
{
    private int _maximumMana = 100;
    private int _mana = 100;

    private List<Spell> _spells = new()
    {
        new Spell("Fireball", 45, 40)
    };

    public Fighter4() : base("Mage", 70, 5, 10)
    {
        
    }

    public override void DealDamageTo(Fighter fighter)
    {
        int dealtDamage;
        // Изменить поиск заклинания не по индексу, а по названию
        if (_mana >= _spells[0].GetSpellManaCost())
        {
            dealtDamage = _spells[0].GetSpellDamage();
            fighter.TakeDamage(dealtDamage);
            _mana -= _spells[0].GetSpellManaCost();
        }
        else
        {
            base.DealDamageTo(fighter);
        }
    }
}