namespace Task_9;

public static class ArenaFighters
{
    private static List<Fighter> _fighters = new()
    {
        new Fighter1(),
        new Fighter2(),
        new Fighter3(),
        new Fighter4(),
        new Fighter5()
    };
    
    public static IReadOnlyList<Fighter> Fighters => _fighters;
}