namespace CityOfGuilds.Legion.Data.Entities;

/// <summary>
///     Represents the bad luck history for an item not dropping for a character.
/// </summary>
public class CharacterItemBadLuck
{
    /// <summary>
    ///     Composite Primary Foreign Key for Character
    /// </summary>
    public int CharacterId { get; set; }

    /// <summary>
    ///     Composite Primary Foreign Key for Item
    /// </summary>
    public int ItemId { get; set; }


    /// <summary>
    ///     How many drop attempts have been made since the last time this item dropped for this player.
    /// </summary>
    public int AttemptsSinceLastDrop { get; set; }


    // Navigation Properties
    public Character Character { get; set; }
    public Item Item { get; set; }
}
