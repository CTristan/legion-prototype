using CityOfGuilds.Legion.Core.Library.Loot;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.Loot;

public sealed class LootGeneratorTests
{
    [Fact]
    public void GenerateLoot_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var generator = GetGenerator();
        var request = TestData.DefaultGenerateLootRequest;

        // Act
        var result = generator.GenerateLoot(request);

        // Assert
        result.Should().NotBeNull();
        result.ItemsGenerated.Should().NotBeNullOrEmpty();
    }

    private static ILootGenerator GetGenerator()
    {
        var itemDropChanceCalculator = Substitute.For<IItemDropChanceCalculator>();
        var potentialLootRetriever = Substitute.For<IPotentialLootRetriever>();

        return new LootGenerator(itemDropChanceCalculator, potentialLootRetriever);
    }
}
