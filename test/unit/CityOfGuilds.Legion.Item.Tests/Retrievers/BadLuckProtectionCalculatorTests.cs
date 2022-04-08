using CityOfGuilds.Legion.Item.Interfaces;
using CityOfGuilds.Legion.Item.Retrievers;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Item.Tests.Retrievers;

public sealed class BadLuckHistoryRetrieverTests
{
    [Fact]
    public void Test1()
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
