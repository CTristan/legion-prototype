using CityOfGuilds.Legion.Core.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Core.BadLuckProtection.Responses;

namespace CityOfGuilds.Legion.Core.BadLuckProtection.Interfaces;

public interface IBadLuckHistoryRetriever
{
    BadLuckHistoryResponse GetBadLuckHistory(BadLuckHistoryRequest request);
}
