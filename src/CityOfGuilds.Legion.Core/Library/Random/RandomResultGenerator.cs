using CityOfGuilds.Legion.Core.Library.Random.Interfaces;

namespace CityOfGuilds.Legion.Core.Library.Random;

public sealed class RandomResultGenerator : IRandomResultGenerator
{
    private readonly System.Random _random;

    public RandomResultGenerator()
    {
        _random = new System.Random();
    }

    public RandomResultGenerator(int seed)
    {
        _random = new System.Random(seed);
    }

    public bool GeneratePassFailResult(float chancePercentage)
    {
        var randomValue = _random.NextSingle() * 100.00f;
        return randomValue >= chancePercentage;
    }
}
