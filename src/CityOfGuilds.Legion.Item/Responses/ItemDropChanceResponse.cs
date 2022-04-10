namespace CityOfGuilds.Legion.Item.Responses;

public sealed class ItemDropChanceResponse
{
    public Core.Object.Item Item { get; set; }
    public float DropChance { get; set; }
}
