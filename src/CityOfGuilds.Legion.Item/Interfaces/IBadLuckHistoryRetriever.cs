using CityOfGuilds.Legion.Item.Requests;
using CityOfGuilds.Legion.Item.Responses;

namespace CityOfGuilds.Legion.Item.Interfaces;

public interface IBadLuckHistoryRetriever
{
    BadLuckHistoryResponse GetBadLuckHistory(BadLuckHistoryRequest request);
}
