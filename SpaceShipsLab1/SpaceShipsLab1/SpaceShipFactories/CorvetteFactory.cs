using SpaceShipsLab1.Crew;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.Weapon;

namespace SpaceShipsLab1.SpaceShipFactories
{
    class CorvetteFactory : ISpaceShipFactory
    {
        public ICrew createCrew()
        {
            return new CorvetteCrew();
        }

        public IExtraAbility createExtraAbility()
        {
            return new NoiseReduction();
        }

        public IStorageUnit createStorageUnit()
        {
            return new CorvetteStorageUnit();
        }

        public IWeapon createWeapon()
        {
            return new LongDistanceGun();
        }
    }
}
