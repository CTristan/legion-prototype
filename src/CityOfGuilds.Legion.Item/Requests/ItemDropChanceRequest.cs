namespace CityOfGuilds.Legion.Item.Requests;

public sealed class ItemDropChanceRequest
{
    public Core.Object.Item Item { get; set; }
    public int PlayerId { get; set; }
}
