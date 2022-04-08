using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Responses;

public sealed class ItemDropChanceResponse
{
    public Item Item { get; set; }
    public float DropChance { get; set; }
}