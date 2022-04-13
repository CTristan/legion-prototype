using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.Loot.Requests;

public sealed class ItemDropChanceRequest
{
    public Item Item { get; set; }
    public int PlayerId { get; set; }
}