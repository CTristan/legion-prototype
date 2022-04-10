using CityOfGuilds.Legion.Core.Repository;
using CityOfGuilds.Legion.Core.Repository.Interfaces;
using FluentAssertions;
using Xunit;

namespace CityOfGuilds.Legion.Core.Tests.Repository;

public sealed class CharacterItemBadLuckRepositoryTests
{
    [Fact]
    public void GetBadLuckHistory_ValidRequest_ReturnsValidResponse()
    {
        // Arrange
        var repository = GetRepository();
        var request = TestData.DefaultCharacterItemBadLuckHistoryRequest;

        // Act
        var result = repository.GetBadLuckHistory(request);

        // Assert
        result.Should().NotBeNull();
    }

    #region Helper Methods

    private static ICharacterItemBadLuckRepository GetRepository()
    {
        return new CharacterItemBadLuckRepository();
    }

    #endregion
}
