using CityOfGuilds.Legion.Item.Interfaces;
using CityOfGuilds.Legion.Item.Requests;
using CityOfGuilds.Legion.Item.Responses;

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
