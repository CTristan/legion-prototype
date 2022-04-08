using CityOfGuilds.Legion.Core.Requests;
using CityOfGuilds.Legion.Core.Responses;

namespace CityOfGuilds.Legion.Item.Interfaces;

public interface IItemDropChanceCalculator
{
    ItemDropChanceResponse CalculateDropChance(ItemDropChanceRequest request);
}