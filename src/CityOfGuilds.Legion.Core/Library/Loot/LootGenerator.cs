using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using CityOfGuilds.Legion.Core.Library.Loot.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Responses;

namespace CityOfGuilds.Legion.Core.Library.Loot;

internal sealed class LootGenerator : ILootGenerator
{
    private readonly IItemDropChanceCalculator _dropChanceCalculator;
    private readonly IPotentialLootRetriever _potentialLootRetriever;

    public LootGenerator(IItemDropChanceCalculator dropChanceCalculator, IPotentialLootRetriever potentialLootRetriever)
    {
        _dropChanceCalculator = dropChanceCalculator;
        _potentialLootRetriever = potentialLootRetriever;
    }

    public GenerateLootResponse GenerateLoot(GenerateLootRequest request)
    {
        var response = new GenerateLootResponse();
        var potentialItems = _potentialLootRetriever.GetPotentialLoot(request.EnemyType);

        foreach (var item in potentialItems)
        {
            var dropChanceRequest = new ItemDropChanceRequest { Item = item, PlayerId = request.PlayerId };
            var dropChance = _dropChanceCalculator.CalculateDropChance(dropChanceRequest);
        }

        return response;
    }
}
