using CityOfGuilds.Legion.Repository.Requests;

namespace CityOfGuilds.Legion.Repository.Tests;

public static class TestData
{
    public static CharacterItemBadLuckHistoryRequest DefaultPlayerItemDropChanceRequest =>
        new() { PlayerId = 1, ItemId = 1 };
}