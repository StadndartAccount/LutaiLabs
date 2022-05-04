using System;

using SpaceShipsLab1.Crew;
using SpaceShipsLab1.ExtraAbility;
using SpaceShipsLab1.StorageUnit;
using SpaceShipsLab1.Weapon;

namespace SpaceShipsLab1
{
    /*
         Создайте Абстрактную фабрику для производства 3-х семейств космического флота – Корвета, Эсминца, Крейсера.
         Космический корабль имеет 3 атрибута: грузоподъемность, тип вооружения и количество экипажа.
         У каждого из кораблей могут быть различные дополнительные атрибуты(например, продолжительность непрерывного хода).
         Добавить 1 уникальный атрибут для каждого типа космического корабля.
         Предусмотреть возможность производства нескольких однотипных семейств и хранения произведенных компонентов.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Запчасти эсминца
            ShowInfo(
                WeaponFactory.CreateDestroyerWeapon(),
                CrewFactory.CreateDestroyerCrew(),
                StorageUnitFactory.CreateDestroyerStorageUnit(),
                ExtraAbilityFactory.CreateDestroyerAbility()
            );

            // Запчасти корвета
            ShowInfo(
                WeaponFactory.CreateCorvetteWeapon(),
                CrewFactory.CreateCorvetteCrew(),
                StorageUnitFactory.CreateCorvetteStorageUnit(),
                ExtraAbilityFactory.CreateCorvetteAbility()
            );

            // Запчасти крейсера
            ShowInfo(
                WeaponFactory.CreateCruiserWeapon(),
                CrewFactory.CreateCruiserCrew(),
                StorageUnitFactory.CreateCruiserStorageUnit(),
                ExtraAbilityFactory.CreateCruiserAbility()
            );
        }

        static void ShowInfo(
            IWeapon weapon,
            ICrew crew,
            IStorageUnit storageUnit,
            IExtraAbility ability
            )
        {
            weapon.GetWeaponInfo();
            crew.GetCrewMembers();
            storageUnit.GetStorageUnitInfo();
            ability.GetExtraAbilityInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
