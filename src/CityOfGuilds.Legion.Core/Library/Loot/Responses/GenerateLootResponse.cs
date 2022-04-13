using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.Loot.Responses;

public class GenerateLootResponse
{
    public IEnumerable<Item> ItemsGenerated { get; set; }
}