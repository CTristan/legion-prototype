using CityOfGuilds.Legion.Core.BadLuckProtection.Interfaces;
using CityOfGuilds.Legion.Core.BadLuckProtection.Retrievers;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.BadLuckProtection.Retrievers;

public sealed class BadLuckHistoryRetrieverTests
{
    [Fact]
    public void GetBadLuckHistory_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var retriever = GetRetriever();
        var request = TestData.DefaultBadLuckProtectionRequest;

        // Act
        var result = retriever.GetBadLuckHistory(request);

        // Assert
        result.Should().NotBeNull();
    }

    private static IBadLuckHistoryRetriever GetRetriever()
    {
        return new BadLuckHistoryRetriever();
    }
}
