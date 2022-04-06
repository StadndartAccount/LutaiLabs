using System;
using SpaceShipsLab1.Crew;
using SpaceShipsLab1.Weapon;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.SpaceShipFactories;

namespace SpaceShipsLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpaceShipFactory corvetteFactory = new CorvetteFactory();
            ISpaceShipFactory destroyerFactory = new DestroyerFactory();
            ISpaceShipFactory cruiserFactory = new CruiserFactory();

            GetInfoAboutFactory(corvetteFactory, "corvette factory");
            GetInfoAboutFactory(destroyerFactory, "destroyer factory");
            GetInfoAboutFactory(cruiserFactory, "cruiser factory");
        }

        static void GetInfoAboutFactory(ISpaceShipFactory factory, String factoryTitle)
        {
            Console.WriteLine();
            Console.WriteLine(factoryTitle.ToUpper());
            factory.createCrew().GetCrewMembers();
            factory.createWeapon().GetWeaponInfo();
            factory.createStorageUnit().GetStorageUnitInfo();
            factory.createExtraAbility().GetExtraAbilityInfo();
            Console.WriteLine();
        }
    }   
}
