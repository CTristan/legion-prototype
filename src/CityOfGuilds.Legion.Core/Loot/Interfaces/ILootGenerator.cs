using CityOfGuilds.Legion.Core.Loot.Requests;
using CityOfGuilds.Legion.Core.Loot.Responses;

namespace CityOfGuilds.Legion.Core.Loot.Interfaces;

public interface ILootGenerator
{
    GenerateLootResponse GenerateLoot(GenerateLootRequest request);
}
