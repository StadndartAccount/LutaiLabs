namespace SpaceShipsLab1.StorageUnit
{
    class StorageUnitFactory
    {
        public static IStorageUnit CreateDestroyerStorageUnit()
        {
            return new DestroyerStorageUnit();
        }

        public static IStorageUnit CreateCorvetteStorageUnit()
        {
            return new CorvetteStorageUnit();
        }

        public static IStorageUnit CreateCruiserStorageUnit()
        {
            return new CruiserStorageUnit();
        }
    }
}
