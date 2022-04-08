namespace CityOfGuilds.Legion.Core.Enum;

public enum GuildPassiveTraits
{
    None = 0,

    /// <summary>
    ///     Senate trait. Gives the player the teleport ability.
    /// </summary>
    Teleportation = 1,

    /// <summary>
    ///     TODO: House trait.
    /// </summary>
    Flash = 2,

    /// <summary>
    ///     TODO: Cult trait.
    /// </summary>
    Menace = 3,

    /// <summary>
    ///     Clan trait. Running turns the player's melee attack into a shoulder charge that does exponentially-more damage and
    ///     knocks the enemy back, stunning them.
    /// </summary>
    Haste = 4,

    /// <summary>
    ///     Conclave trait. Healing reloads ammo.
    /// </summary>
    Vigilance = 5,

    /// <summary>
    ///     Syndicate trait. Dealing damage heals the player for a percentage of the damage dealt.
    /// </summary>
    Lifelink = 6,

    /// <summary>
    ///     League trait. Using an ability increases all damage dealt for a short time.
    /// </summary>
    Prowess = 7,

    /// <summary>
    ///     Swarm trait. Precision shots deal exponentially more damage for every percent less the enemy's health is from 20
    ///     percent.
    /// </summary>
    Deathtouch = 8,

    /// <summary>
    ///     TODO: Legion trait.
    /// </summary>
    DoubleStrike = 9,

    /// <summary>
    ///     Combine trait. Debuffs affect the player for less time. Immune to debuffs after a certain level difference.
    /// </summary>
    Hexproof = 10
}
