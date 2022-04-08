using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Requests;

public sealed class ItemDropChanceRequest
{
    public Item Item { get; set; }
    public int PlayerId { get; set; }
}
