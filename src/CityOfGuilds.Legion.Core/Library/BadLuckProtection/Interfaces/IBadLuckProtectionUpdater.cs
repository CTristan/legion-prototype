using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;

namespace CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;

public interface IBadLuckProtectionUpdater
{
    bool Update(BadLuckProtectionUpdateRequest request);
}