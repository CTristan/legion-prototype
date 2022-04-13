using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;

public class BadLuckProtectionRequest
{
    public int PlayerId { get; set; }
    public Item Item { get; set; }
}