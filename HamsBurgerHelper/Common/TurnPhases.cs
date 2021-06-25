namespace HamsBurgerHelper.Common
{
    /// <summary>
    /// Enum representing the different phases that make up a turn.
    /// </summary>
    public enum TurnPhases
    {
        Command = 1, 
        Movement = 2,
        Psychic = 3,
        Shooting = 4,
        Charge = 5,
        Fight = 6,
        Morale = 7,
        Any = 8,
        None = 9
    }
}