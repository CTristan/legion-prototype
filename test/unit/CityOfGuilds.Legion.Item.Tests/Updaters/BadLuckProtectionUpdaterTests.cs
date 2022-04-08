using CityOfGuilds.Legion.Item.Interfaces;
using CityOfGuilds.Legion.Item.Updaters;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Item.Tests.Updaters;

public sealed class BadLuckProtectionUpdaterTests
{
    [Fact]
    public void Update_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var updater = GetUpdater();
        var request = TestData.DefaultBadLuckProtectionUpdateRequest;

        // Act
        var result = updater.Update(request);

        // Assert
        result.Should().BeTrue();
    }

    private static IBadLuckProtectionUpdater GetUpdater()
    {
        return new BadLuckProtectionUpdater();
    }
}
