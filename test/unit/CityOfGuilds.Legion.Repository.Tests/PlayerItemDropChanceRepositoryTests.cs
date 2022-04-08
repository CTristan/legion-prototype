using CityOfGuilds.Legion.Repository.Interfaces;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Repository.Tests;

public sealed class PlayerItemDropChanceRepositoryTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var repository = GetRepository();
        var request = TestData.DefaultPlayerItemDropChanceRequest;

        // Act
        var result = repository.GetPlayerItemDropChance(request);

        // Assert
        result.Should().NotBeNull();
    }

    #region Helper Methods

    private static IPlayerItemDropChanceRepository GetRepository()
    {
        return new PlayerItemDropChanceRepository();
    }

    #endregion
}
