using CityOfGuilds.Legion.Core.Library.Loot.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Responses;

namespace CityOfGuilds.Legion.Core.Library.Loot.Interfaces;

public interface IItemDropChanceCalculator
{
    ItemDropChanceResponse CalculateDropChance(ItemDropChanceRequest request);
}