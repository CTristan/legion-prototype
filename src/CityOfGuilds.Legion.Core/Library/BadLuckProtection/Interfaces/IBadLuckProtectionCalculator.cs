using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Requests;
using CityOfGuilds.Legion.Core.Library.BadLuckProtection.Responses;

namespace CityOfGuilds.Legion.Core.Library.BadLuckProtection.Interfaces;

public interface IBadLuckProtectionCalculator
{
    BadLuckProtectionResponse CalculateBadLuckProtection(BadLuckProtectionRequest request);
}