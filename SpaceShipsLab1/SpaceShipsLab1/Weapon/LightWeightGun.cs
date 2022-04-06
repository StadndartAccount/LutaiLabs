using System;

namespace SpaceShipsLab1.Weapon
{
    class LightWeightGun : IWeapon
    {
        public void GetWeaponInfo()
        {
            Console.WriteLine("Weapon class: light-weight");
        }
    }
}
