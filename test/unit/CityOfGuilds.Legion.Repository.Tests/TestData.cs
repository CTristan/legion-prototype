using CityOfGuilds.Legion.Repository.Requests;

namespace CityOfGuilds.Legion.Repository.Tests;

public static class TestData
{
    public static PlayerItemDropChanceRequest DefaultPlayerItemDropChanceRequest => new() { PlayerId = 1, ItemId = 1 };
}
