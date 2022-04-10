namespace CityOfGuilds.Legion.Core.Repository.Requests;

public sealed class CharacterItemBadLuckHistoryRequest
{
    public string ConnectionString { get; set; }
    public int PlayerId { get; set; }
    public int ItemId { get; set; }
}