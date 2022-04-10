using CityOfGuilds.Legion.Item.Requests;
using CityOfGuilds.Legion.Item.Responses;

namespace CityOfGuilds.Legion.Item.Interfaces;

public interface IItemGenerator
{
    ItemDropChanceResponse CheckForDropChance(ItemDropChanceRequest request);
}