namespace SpaceShipsLab1.Crew
{
    class CrewFactory
    {
        public static ICrew CreateDestroyerCrew()
        {
            return new DestroyerCrew();
        }

        public static ICrew CreateCorvetteCrew()
        {
            return new CorvetteCrew();
        }

        public static ICrew CreateCruiserCrew()
        {
            return new CruiserCrew();
        }
    }
}
