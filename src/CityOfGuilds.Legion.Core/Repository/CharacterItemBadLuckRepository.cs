using CityOfGuilds.Legion.Core.Repository.Interfaces;
using CityOfGuilds.Legion.Core.Repository.Requests;
using CityOfGuilds.Legion.Core.Repository.Responses;

namespace CityOfGuilds.Legion.Core.Repository;

internal sealed class CharacterItemBadLuckRepository : ICharacterItemBadLuckRepository
{
    public CharacterItemBadLuckHistoryResponse GetBadLuckHistory(CharacterItemBadLuckHistoryRequest request)
    {
        var response = new CharacterItemBadLuckHistoryResponse();

        return response;
    }
}
