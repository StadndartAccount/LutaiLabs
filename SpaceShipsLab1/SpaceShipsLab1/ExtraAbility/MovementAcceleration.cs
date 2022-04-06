using System;

namespace SpaceShipsLab1.ExtraAbility
{
    class MovementAcceleration : IExtraAbility
    {
        public void GetExtraAbilityInfo()
        {
            Console.WriteLine("extra ability: 15% movement acceleration");
        }
    }
}
