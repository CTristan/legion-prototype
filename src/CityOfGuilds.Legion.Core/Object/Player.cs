using CityOfGuilds.Legion.Core.Object.Armor;
using CityOfGuilds.Legion.Core.Object.Equipment;
using CityOfGuilds.Legion.Core.Object.Weapon;

namespace CityOfGuilds.Legion.Core.Object;

internal class Player
{
    public Player(PrimaryWeapon primaryWeapon, SpecialWeapon specialWeapon, HeavyWeapon heavyWeapon,
        HeadArmor headArmor, ArmArmor armArmor, ChestArmor chestArmor, LegArmor legArmor, GuildRelic guildRelic)
    {
        PrimaryWeapon = primaryWeapon;
        SpecialWeapon = specialWeapon;
        HeavyWeapon = heavyWeapon;
        HeadArmor = headArmor;
        ArmArmor = armArmor;
        ChestArmor = chestArmor;
        LegArmor = legArmor;
        GuildRelic = guildRelic;
    }

    public int Id { get; set; }

    private PrimaryWeapon PrimaryWeapon { get; }
    private SpecialWeapon SpecialWeapon { get; }
    private HeavyWeapon HeavyWeapon { get; }
    private HeadArmor HeadArmor { get; }
    private ArmArmor ArmArmor { get; }
    private ChestArmor ChestArmor { get; }
    private LegArmor LegArmor { get; }
    private GuildRelic GuildRelic { get; }
}
