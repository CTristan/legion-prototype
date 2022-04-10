using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Item.Requests;

namespace CityOfGuilds.Legion.Item.Tests;

internal static class TestData
{
    private static Core.Object.Item DefaultItem => new() { Id = 1, Rarity = Rarities.Basic };
    public static ItemDropChanceRequest DefaultItemDropChanceRequest => new() { Item = DefaultItem, PlayerId = 1 };
}
