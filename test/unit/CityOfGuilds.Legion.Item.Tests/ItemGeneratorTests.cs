using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using CityOfGuilds.Legion.Item.Interfaces;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace CityOfGuilds.Legion.Item.Tests;

public sealed class ItemGeneratorTests
{
    [Fact]
    public void CheckForItemDrop_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var generator = GetGenerator();
        var request = TestData.DefaultItemDropChanceRequest;

        // Act
        var result = generator.CheckForDropChance(request);

        // Assert
        result.Should().NotBeNull();
        result.Item.Should().NotBeNull();
    }

    private static IItemGenerator GetGenerator()
    {
        var itemDropChanceCalculator = Substitute.For<IItemDropChanceCalculator>();
        var badLuckProtectionUpdater = Substitute.For<IBadLuckProtectionUpdater>();

        return new ItemGenerator(itemDropChanceCalculator, badLuckProtectionUpdater);
    }
}