using CityOfGuilds.Legion.Repository.Requests;
using CityOfGuilds.Legion.Repository.Responses;

namespace CityOfGuilds.Legion.Repository.Interfaces;

public interface ICharacterItemBadLuckRepository
{
    CharacterItemBadLuckHistoryResponse GetBadLuckHistory(CharacterItemBadLuckHistoryRequest request);
}
