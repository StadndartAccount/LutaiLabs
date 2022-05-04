using System;

namespace SpaceShipsLab1.ExtraAbility
{
    class DamageBoost : IExtraAbility
    {
        public void GetExtraAbilityInfo()
        {
            Console.WriteLine("extra ability: 25% damage boost");
        }
    }
}
