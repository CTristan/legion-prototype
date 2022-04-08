namespace CityOfGuilds.Legion.Item.Requests;

public sealed class BadLuckHistoryRequest
{
    public Core.Object.Item Item { get; set; }
    public int PlayerId { get; set; }
}
