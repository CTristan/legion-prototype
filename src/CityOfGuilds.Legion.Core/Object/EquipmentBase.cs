using CityOfGuilds.Legion.Core.Enum;

namespace CityOfGuilds.Legion.Core.Object;

internal class EquipmentBase : Item
{
    public EquipmentTypes EquipmentType { get; set; }
    public int PowerLevel { get; set; }
}
