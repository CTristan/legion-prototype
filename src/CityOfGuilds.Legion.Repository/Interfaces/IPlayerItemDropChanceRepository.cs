using CityOfGuilds.Legion.Repository.Requests;
using CityOfGuilds.Legion.Repository.Responses;

namespace CityOfGuilds.Legion.Repository.Interfaces;

public interface IPlayerItemDropChanceRepository
{
    PlayerItemDropChanceResponse GetPlayerItemDropChance(PlayerItemDropChanceRequest request);
}
