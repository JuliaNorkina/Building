namespace BuildingProg
{
     public class Building
    {
        int id;
        static int idGenerator = 0;
        double height;
        int numberOfStoreys;
        int numberOfApartments;
        int numberOfEntrances;

        public Building()
        {
            id = generator();
        }

        public void setHeight(double height) {
            this.height = height;
        }

        public void setNumberOfStoreys(int numberOfStoreys)
        {
            this.numberOfStoreys = numberOfStoreys;
        }

        public void setNumberOfApartments(int numberOfApartments)
        {
            this.numberOfApartments = numberOfApartments;
        }

        public void setNumberOfEntrances(int numberOfEntrances)
        {
            this.numberOfEntrances = numberOfEntrances;
        }

        public double getHeight()
        {
            return height;
        }

        public int getNumberOfStoreys()
        {
            return numberOfStoreys;
        }

        public int getNumberOfApartments()
        {
            return numberOfApartments;
        }

        public int getNumberOfEntrances()
        {
            return numberOfEntrances;
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
