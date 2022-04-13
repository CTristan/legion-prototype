using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;

public sealed class BadLuckHistoryRequest
{
    public Item Item { get; set; }
    public int PlayerId { get; set; }
}