using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.Library.Loot;
using CityOfGuilds.Legion.Core.Library.Loot.Interfaces;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.Loot;

public sealed class ItemDropChanceCalculatorTests
{
    [Fact]
    public void CalculateDropChance_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var calculator = GetCalculator();
        var request = TestData.DefaultItemDropChanceRequest;

        // Act
        var result = calculator.CalculateDropChance(request);

        // Assert
        result.Should().NotBeNull();
        result.Item.Should().NotBeNull();
    }

    private static IItemDropChanceCalculator GetCalculator()
    {
        var badLuckProtectionCalculator = Substitute.For<IBadLuckProtectionCalculator>();

        return new ItemDropChanceCalculator(badLuckProtectionCalculator);
    }
}