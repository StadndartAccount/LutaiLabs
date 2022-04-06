using System;

namespace SpaceShipsLab1.ExtraAbility
{
    class NoiseReduction : IExtraAbility
    {
        public void GetExtraAbilityInfo()
        {
            Console.WriteLine("extra ability: 40% noise reduction");
        }
    }
}
