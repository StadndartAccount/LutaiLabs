using SpaceShipsLab1.Crew;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.Weapon;

namespace SpaceShipsLab1.SpaceShipFactories
{
    class DestroyerFactory : ISpaceShipFactory
    {
        public ICrew createCrew()
        {
            return new DestroyerCrew();
        }

        public IExtraAbility createExtraAbility()
        {
            return new DamageBoost();
        }

        public IStorageUnit createStorageUnit()
        {
            return new DestroyerStorageUnit();
        }

        public IWeapon createWeapon()
        {
            return new RapidFiringGun();
        }
    }
}
