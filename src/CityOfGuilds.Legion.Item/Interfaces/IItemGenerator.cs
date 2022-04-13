using CityOfGuilds.Legion.Core.Library.Loot.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Responses;

namespace CityOfGuilds.Legion.Item.Interfaces;

public interface IItemGenerator
{
    ItemDropChanceResponse CheckForDropChance(ItemDropChanceRequest request);
}