using CityOfGuilds.Legion.Core.Enum;

namespace CityOfGuilds.Legion.Core.Loot.Requests;

public class GenerateLootRequest
{
    public int PlayerId { get; }
    public EnemyTypes EnemyType { get; }
}
