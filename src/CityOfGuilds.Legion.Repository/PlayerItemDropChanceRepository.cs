using CityOfGuilds.Legion.Repository.Interfaces;
using CityOfGuilds.Legion.Repository.Requests;
using CityOfGuilds.Legion.Repository.Responses;

namespace CityOfGuilds.Legion.Repository;

public sealed class PlayerItemDropChanceRepository : IPlayerItemDropChanceRepository
{
    public PlayerItemDropChanceResponse GetPlayerItemDropChance(PlayerItemDropChanceRequest request)
    {
        var response = new PlayerItemDropChanceResponse();

        return response;
    }
}
