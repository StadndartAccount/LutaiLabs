using SpaceShipsLab1.Crew;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.Weapon;

namespace SpaceShipsLab1.SpaceShipFactories
{
    class CruiserFactory : ISpaceShipFactory
    {
        public ICrew createCrew()
        {
            return new CruiserCrew();
        }

        public IExtraAbility createExtraAbility()
        {
            return new MovementAcceleration();
        }

        public IStorageUnit createStorageUnit()
        {
            return new CruiserStorageUnit();
        }

        public IWeapon createWeapon()
        {
            return new LightWeightGun();
        }
    }
}
