using CityOfGuilds.Legion.Core.Enum;

namespace CityOfGuilds.Legion.Core.Library.Loot.Requests;

public sealed class GenerateLootRequest
{
    internal int PlayerId { get; set; }
    internal EnemyTypes EnemyType { get; set; }
}