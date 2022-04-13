using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Core.Library.Loot.Requests;
using CityOfGuilds.Legion.Core.Object;
using CityOfGuilds.Legion.Core.Repository.Requests;

namespace CityOfGuilds.Legion.Core.Tests;

internal static class TestData
{
    public static BadLuckHistoryRequest DefaultBadLuckHistoryRequest => new() { PlayerId = 1, Item = DefaultItem };

    public static BadLuckProtectionRequest DefaultBadLuckProtectionRequest =>
        new() { Item = DefaultItem, PlayerId = 1 };

    public static BadLuckProtectionUpdateRequest DefaultBadLuckProtectionUpdateRequest =>
        new() { PlayerId = 1, ItemId = 1, UpdatedAttemptCount = 1 };


    public static CharacterItemBadLuckHistoryRequest DefaultCharacterItemBadLuckHistoryRequest =>
        new() { PlayerId = 1, ItemId = 1 };

    public static GenerateLootRequest DefaultGenerateLootRequest =>
        new() { PlayerId = 1, EnemyType = EnemyTypes.Basic };

    private static Item DefaultItem => new() { Id = 1, Rarity = Rarities.Basic };

    public static ItemDropChanceRequest DefaultItemDropChanceRequest => new() { Item = DefaultItem, PlayerId = 1 };
}