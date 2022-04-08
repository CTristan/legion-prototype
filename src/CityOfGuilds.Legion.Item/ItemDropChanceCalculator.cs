using CityOfGuilds.Legion.Core.Requests;
using CityOfGuilds.Legion.Core.Responses;
using CityOfGuilds.Legion.Item.Interfaces;

namespace CityOfGuilds.Legion.Item;

public sealed class ItemDropChanceCalculator : IItemDropChanceCalculator
{
    public ItemDropChanceResponse CalculateDropChance(ItemDropChanceRequest request)
    {
        var response = new ItemDropChanceResponse { Item = request.Item };

        response.DropChance = 0.00f;

        return response;
    }
}
