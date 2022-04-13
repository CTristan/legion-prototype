using CityOfGuilds.Legion.Core.Library.BadLuckProtection;
using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.BadLuckProtection;

public sealed class BadLuckProtectionCalculatorTests
{
    [Fact]
    public void Calculate_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var calculator = GetCalculator();
        var request = TestData.DefaultBadLuckProtectionRequest;

        // Act
        var result = calculator.CalculateBadLuckProtection(request);

        // Assert
        result.Should().NotBeNull();
        result.BadLuckProtectionPercentage.Should().BeGreaterThan(0.00f);
    }

    private static IBadLuckProtectionCalculator GetCalculator()
    {
        return new BadLuckProtectionCalculator();
    }
}