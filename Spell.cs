namespace Task_9;

public class Spell
{
    private string _spellName;
    private int _spellManaCost;
    private int _spellDamage;

    public Spell(string spellName, int spellManaCost, int spellDamage)
    {
        _spellName = spellName;
        _spellManaCost = spellManaCost;
        _spellDamage = spellDamage;
    }

    public int GetSpellManaCost()
    {
        return _spellManaCost;
    }

    public int GetSpellDamage()
    {
        return _spellDamage;
    }

    public string GetSpellName()
    {
        return _spellName;
    }
}