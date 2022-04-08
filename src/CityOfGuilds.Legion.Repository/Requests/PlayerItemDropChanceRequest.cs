namespace CityOfGuilds.Legion.Repository.Requests;

public class PlayerItemDropChanceRequest
{
    public string ConnectionString { get; set; }
    public int PlayerId { get; set; }
    public int ItemId { get; set; }
}
