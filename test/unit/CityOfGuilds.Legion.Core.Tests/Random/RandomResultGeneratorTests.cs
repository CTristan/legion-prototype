using CityOfGuilds.Legion.Core.Library.Random;
using CityOfGuilds.Legion.Core.Library.Random.Interfaces;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.Random;

public sealed class RandomResultGeneratorTests
{
    [Fact]
    public void GeneratePassFailResult_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        const float chancePercentage = 100.00f;
        var generator = GetGenerator();

        // Act
        var result = generator.GeneratePassFailResult(chancePercentage);

        // Assert
        result.Should().BeTrue();
    }

    private static IRandomResultGenerator GetGenerator(int? seed = null)
    {
        return seed == null ? new RandomResultGenerator() : new RandomResultGenerator((int)seed);
    }
}
