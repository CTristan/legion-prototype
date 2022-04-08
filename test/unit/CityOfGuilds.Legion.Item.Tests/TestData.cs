using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Requests;
using CityOfGuilds.Legion.Item.Requests;

namespace CityOfGuilds.Legion.Item.Tests;

internal static class TestData
{
    public static BadLuckHistoryRequest DefaultBadLuckProtectionRequest => new() { PlayerId = 1, Item = DefaultItem };

    public static BadLuckProtectionUpdateRequest DefaultBadLuckProtectionUpdateRequest =>
        new() { PlayerId = 1, ItemId = 1, UpdatedAttemptCount = 1 };

    private static Core.Object.Item DefaultItem => new() { Id = 1, Rarity = Rarities.Basic };
    public static ItemDropChanceRequest DefaultItemDropChanceRequest => new() { Item = DefaultItem, PlayerId = 1 };
}
