using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Object;

namespace CityOfGuilds.Legion.Core.Library.Loot.Interfaces;

public interface IPotentialLootRetriever
{
    IEnumerable<Item> GetPotentialLoot(EnemyTypes enemyType);
}