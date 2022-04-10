using CityOfGuilds.Legion.Core.BadLuckProtection.Requests;

namespace CityOfGuilds.Legion.Core.BadLuckProtection.Interfaces;

public interface IBadLuckProtectionUpdater
{
    bool Update(BadLuckProtectionUpdateRequest request);
}