namespace CityOfGuilds.Legion.Data.Entities;

/// <summary>
///     Represents information for an individual character for a player.
/// </summary>
public class Character
{
    /// <summary>
    ///     Primary Key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Foreign Key for Player
    /// </summary>
    public int PlayerId { get; set; }

    // Navigation Properties
    public Player Player { get; set; }
}
