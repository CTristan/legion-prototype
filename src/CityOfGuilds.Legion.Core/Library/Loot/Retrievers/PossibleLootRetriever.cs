using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.Loot.Retrievers;

public class PotentialLootRetriever : IPotentialLootRetriever
{
    public IEnumerable<Item> GetPotentialLoot(EnemyTypes enemyType)
    {
        throw new NotImplementedException();
    }
}