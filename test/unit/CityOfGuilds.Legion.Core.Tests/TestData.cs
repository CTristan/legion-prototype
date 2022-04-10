using CityOfGuilds.Legion.Core.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Object;
using CityOfGuilds.Legion.Core.Repository.Requests;

namespace CityOfGuilds.Legion.Core.Tests;

internal static class TestData
{
    public static BadLuckHistoryRequest DefaultBadLuckProtectionRequest => new() { PlayerId = 1, Item = DefaultItem };

    public static BadLuckProtectionUpdateRequest DefaultBadLuckProtectionUpdateRequest =>
        new() { PlayerId = 1, ItemId = 1, UpdatedAttemptCount = 1 };

    public static CharacterItemBadLuckHistoryRequest DefaultCharacterItemBadLuckHistoryRequest =>
        new() { PlayerId = 1, ItemId = 1 };

    public static Item DefaultItem => new() { Id = 1, Rarity = Rarities.Basic };
}
