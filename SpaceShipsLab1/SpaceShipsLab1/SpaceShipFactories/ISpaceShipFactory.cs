using SpaceShipsLab1.Crew;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.Weapon;

namespace SpaceShipsLab1.SpaceShipFactories
{
    interface ISpaceShipFactory
    {
        ICrew createCrew();
        IWeapon createWeapon();
        IStorageUnit createStorageUnit();
        IExtraAbility createExtraAbility();
    }
}
