using CityOfGuilds.Legion.Core.Repository.Requests;
using CityOfGuilds.Legion.Core.Repository.Responses;

namespace CityOfGuilds.Legion.Core.Repository.Interfaces;

internal interface ICharacterItemBadLuckRepository
{
    CharacterItemBadLuckHistoryResponse GetBadLuckHistory(CharacterItemBadLuckHistoryRequest request);
}
