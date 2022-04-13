using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using CityOfGuilds.Legion.Core.Library.Loot.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Responses;

namespace CityOfGuilds.Legion.Core.Library.Loot;

public sealed class ItemDropChanceCalculator : IItemDropChanceCalculator
{
    private readonly IBadLuckProtectionCalculator _badLuckProtectionCalculator;

    public ItemDropChanceCalculator(IBadLuckProtectionCalculator badLuckProtectionCalculator)
    {
        _badLuckProtectionCalculator = badLuckProtectionCalculator;
    }

    public ItemDropChanceResponse CalculateDropChance(ItemDropChanceRequest request)
    {
        var response = new ItemDropChanceResponse { Item = request.Item };

        var badLuckProtectionRequest = new BadLuckProtectionRequest
        {
            Item = request.Item, PlayerId = request.PlayerId
        };
        var badLuckProtection = _badLuckProtectionCalculator.CalculateBadLuckProtection(badLuckProtectionRequest);

        return response;
    }
}