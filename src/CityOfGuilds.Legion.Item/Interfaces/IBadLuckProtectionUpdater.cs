using CityOfGuilds.Legion.Core.Requests;

namespace CityOfGuilds.Legion.Item.Interfaces;

public interface IBadLuckProtectionUpdater
{
    bool Update(BadLuckProtectionUpdateRequest request);
}
