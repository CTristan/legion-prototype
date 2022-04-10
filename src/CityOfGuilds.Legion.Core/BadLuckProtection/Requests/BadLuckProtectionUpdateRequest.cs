namespace CityOfGuilds.Legion.Core.BadLuckProtection.Requests;

public class BadLuckProtectionUpdateRequest
{
    public int PlayerId { get; set; }
    public int ItemId { get; set; }
    public int UpdatedAttemptCount { get; set; }
}