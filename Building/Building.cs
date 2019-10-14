namespace Building
{
    class Building
    {
        int id;
        static int idGenerator = 0;
        double height;
        int numberOfStoreys;
        int numberOfApartments;
        int numberOfEntrances;

        public Building(double height, int numberOfStoreys, int numberOfApartments, int numberOfEntrances)
        {
            id = generator();
            this.height = height;
            this.numberOfStoreys = numberOfStoreys;
            this.numberOfApartments = numberOfApartments;
            this.numberOfEntrances = numberOfEntrances;
        }

        public Building getBuildingInfo()
        {
            return this;
        }

        public double floorHeightCalculations()
        {
            return height / numberOfStoreys;
        }

        public int calculationNumberOfApartmentsInEntrance()
        {

            return numberOfApartments / numberOfEntrances;
        }

        public int calculationNumberOfApartmentsPerFloor()
        {
            return calculationNumberOfApartmentsInEntrance() / numberOfStoreys;
        }

        private int generator()
        {
            return ++idGenerator;
        }
    }
}
