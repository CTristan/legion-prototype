using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Updaters;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.BadLuckProtection.Updaters;

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