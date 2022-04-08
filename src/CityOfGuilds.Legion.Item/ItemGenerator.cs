using CityOfGuilds.Legion.Core.Requests;
using CityOfGuilds.Legion.Core.Responses;
using CityOfGuilds.Legion.Item.Interfaces;

namespace CityOfGuilds.Legion.Item;

public sealed class ItemGenerator : IItemGenerator
{
    private readonly IItemDropChanceCalculator _itemDropChanceCalculator;

    public ItemGenerator(IItemDropChanceCalculator itemDropChanceCalculator)
    {
        _itemDropChanceCalculator = itemDropChanceCalculator;
    }

    public ItemDropChanceResponse CheckForDropChance(ItemDropChanceRequest request)
    {
        var response = _itemDropChanceCalculator.CalculateDropChance(request);

        return response;
    }
}
