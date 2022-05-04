namespace SpaceShipsLab1.ExtraAbility
{
    class ExtraAbilityFactory
    {
        public static IExtraAbility CreateDestroyerAbility()
        {
            return new DamageBoost();
        }

        public static IExtraAbility CreateCorvetteAbility()
        {
            return new NoiseReduction();
        }

        public static IExtraAbility CreateCruiserAbility()
        {
            return new MovementAcceleration();
        }
    }
}
