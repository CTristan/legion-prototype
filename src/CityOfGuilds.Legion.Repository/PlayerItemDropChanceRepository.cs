using CityOfGuilds.Legion.Repository.Interfaces;
using CityOfGuilds.Legion.Repository.Requests;
using CityOfGuilds.Legion.Repository.Responses;

namespace CityOfGuilds.Legion.Repository;

public sealed class PlayerItemDropChanceRepository : ICharacterItemBadLuckRepository
{
    public CharacterItemBadLuckHistoryResponse GetBadLuckHistory(CharacterItemBadLuckHistoryRequest request)
    {
        var response = new CharacterItemBadLuckHistoryResponse();

        return response;
    }
}