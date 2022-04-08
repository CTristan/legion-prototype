namespace CityOfGuilds.Legion.Data.Entities;

/// <summary>
///     Represents the history for an item's chances of dropping for a particular player.
/// </summary>
public class PlayerItemDropChance
{
    /// <summary>
    ///     Composite Primary Foreign Key for Player
    /// </summary>
    public int PlayerId { get; set; }

    /// <summary>
    ///     Composite Primary Foreign Key for Item
    /// </summary>
    public int ItemId { get; set; }


    /// <summary>
    ///     How many drop attempts have been made since the last time this item dropped for this player.
    /// </summary>
    public int AttemptsSinceLastDrop { get; set; }


    // Navigation Properties
    public Player Player { get; set; }
    public Item Item { get; set; }
}
