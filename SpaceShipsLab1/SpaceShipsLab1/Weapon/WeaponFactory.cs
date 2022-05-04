namespace SpaceShipsLab1.Weapon
{
    class WeaponFactory
    {
        public static IWeapon CreateDestroyerWeapon()
        {
            return new RapidFiringGun();
        }

        public static IWeapon CreateCorvetteWeapon()
        {
            return new LightWeightGun();
        }

        public static IWeapon CreateCruiserWeapon()
        {
            return new LongDistanceGun();
        }
    }
}
