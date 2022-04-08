namespace CityOfGuilds.Legion.Core.Enum;

public enum Stats
{
    None = 0,

    /// <summary>
    ///     Primary stat for Order guilds.
    ///     Affects a player's damage resistance and healing power.
    /// </summary>
    Constitution = 1,

    /// <summary>
    ///     Primary stat for Logic guilds.
    ///     Affects how quickly a player's abilities charge.
    /// </summary>
    Intelligence = 2,

    /// <summary>
    ///     Primary stat for Ambition guilds.
    ///     Affects a player's precision damage, stealth time, and stealth effectiveness.
    /// </summary>
    Dexterity = 3,

    /// <summary>
    ///     Primary stat for Passion guilds.
    ///     Affects a player's movement and reaction speed.
    /// </summary>
    Mobility = 4,

    /// <summary>
    ///     Primary stat for Growth guilds.
    ///     Affects a player's melee damage and healing power.
    /// </summary>
    Strength = 5
}