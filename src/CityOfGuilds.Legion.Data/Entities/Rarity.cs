namespace CityOfGuilds.Legion.Data.Entities;

/// <summary>
///     Represents the possible rarity values for an item.
/// </summary>
public class Rarity
{
    /// <summary>
    ///     Primary Key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     The initial drop chance for an item of this rarity.
    /// </summary>
    public decimal DropChance { get; set; }
}
