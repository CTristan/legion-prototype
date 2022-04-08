using CityOfGuilds.Legion.Item.Interfaces;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Item.Tests;

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

    #region Helper Methods

    private static IItemDropChanceCalculator GetCalculator()
    {
        return new ItemDropChanceCalculator();
    }

    #endregion
}
