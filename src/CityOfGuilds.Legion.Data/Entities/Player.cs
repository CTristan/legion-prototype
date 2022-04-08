namespace CityOfGuilds.Legion.Data.Entities;

/// <summary>
///     Represents a player's account-wide information.
/// </summary>
public class Player
{
    /// <summary>
    ///     Primary Key
    /// </summary>
    public int Id { get; set; }


    // Navigation Properties
    public List<Character> Characters { get; set; }
}
