using CityOfGuilds.Legion.Core.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Item.Interfaces;
using CityOfGuilds.Legion.Item.Requests;
using CityOfGuilds.Legion.Item.Responses;

namespace CityOfGuilds.Legion.Item;

public sealed class ItemGenerator : IItemGenerator
{
    private readonly IBadLuckProtectionUpdater _badLuckProtectionUpdater;
    private readonly IItemDropChanceCalculator _itemDropChanceCalculator;

    public ItemGenerator(IItemDropChanceCalculator itemDropChanceCalculator,
        IBadLuckProtectionUpdater badLuckProtectionUpdater)
    {
        _itemDropChanceCalculator = itemDropChanceCalculator;
        _badLuckProtectionUpdater = badLuckProtectionUpdater;
    }

    public ItemDropChanceResponse CheckForDropChance(ItemDropChanceRequest request)
    {
        var response = _itemDropChanceCalculator.CalculateDropChance(request);

        // TODO: Validate whether or not a drop has occurred

        // Update the character's bad luck protection
        var badLuckProtectionUpdateRequest =
            new BadLuckProtectionUpdateRequest { PlayerId = request.PlayerId, ItemId = request.Item.Id };

        _badLuckProtectionUpdater.Update(badLuckProtectionUpdateRequest);

        return response;
    }
}