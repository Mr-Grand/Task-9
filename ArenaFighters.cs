namespace Task_9;

public static class ArenaFighters
{
    private static List<Fighter> _fighters = new()
    {
        new FighterWarrior(),
        new FighterSlayer(),
        new FighterBerserk(),
        new FighterMage(),
        new FighterTrickster()
    };

    public static IReadOnlyList<Fighter> Fighters => _fighters;
}