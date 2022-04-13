using CityOfGuilds.Legion.Core.Enum;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using CityOfGuilds.Legion.Core.Library.Loot.Retrievers;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.Loot;

public sealed class PotentialLootRetrieverTests
{
    [Fact]
    public void GetPotentialLoot_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var retriever = GetRetriever();
        var enemyType = EnemyTypes.Basic;

        // Act
        var result = retriever.GetPotentialLoot(enemyType);

        // Assert
        result.Should().NotBeNullOrEmpty();
    }

    private static IPotentialLootRetriever GetRetriever()
    {
        return new PotentialLootRetriever();
    }
}