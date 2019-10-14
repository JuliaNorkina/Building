using BuildingProg;
using System;
using Xunit;

namespace TestBuilding
{
    public class UnitTest1
    {
        [Fact]
        public void ValidHightTest()
        {
            Building building = new Building();
            building.setHeight(156);

            Assert.Equal(156.0, building.getHeight());
        }

        [Fact]
        public void ValidHightTest1()
        {
            Building building = new Building();
            building.setHeight(1);

            Assert.Equal(1, building.getHeight());
        }

        [Fact]
        public void ZeroHightTest()
        {
            Assert.Throws<ArgumentException>(getZeroHeight);
        }

        private void getZeroHeight()
        {
            Building building = new Building();
            building.setHeight(0);
        }

        [Fact]
        public void MinusOneHightTest()
        {
            Assert.Throws<ArgumentException>(getMinusOneHeight);
        }

        private void getMinusOneHeight()
        {
            Building building = new Building();
            building.setHeight(-1);
        }

        [Fact]
        public void BigNumberMinusOneHightTest()
        {
            Building building = new Building();
            building.setHeight(Double.MaxValue - 1);

            Assert.Equal(Double.MaxValue - 1, building.getHeight());
        }

        [Fact]
        public void BigNumberHightTest()
        {
            Building building = new Building();
            building.setHeight(Double.MaxValue);

            Assert.Equal(Double.MaxValue, building.getHeight());
        }

        [Fact]
        public void NumberBiggerThanTypeDoubleHightTest()
        {
            Assert.Throws<ArgumentException>(getBigNumberHeight);
        }

        private void getBigNumberHeight()
        {
            Building building = new Building();
            building.setHeight(Double.MaxValue + 1);
        }

        [Fact]
        public void ValidNumberOfStoreysTest()
        {
            Building building = new Building();
            building.setNumberOfStoreys(22);

            Assert.Equal(22, building.getNumberOfStoreys());
        }

        [Fact]
        public void ValidNumberOfStoreysTest1()
        {
            Building building = new Building();
            building.setNumberOfStoreys(1);

            Assert.Equal(1, building.getNumberOfStoreys());
        }

        [Fact]
        public void ZeroNumberOfStoreysTest()
        {            
            Assert.Throws<ArgumentException>(getZeroNumberOfStoreys);
        }

        private void getZeroNumberOfStoreys()
        {
            Building building = new Building();
            building.setNumberOfStoreys(0);
        }

        [Fact]
        public void MinusOneNumberOfStoreysTest()
        {
            Assert.Throws<ArgumentException>(getMinusOneNumberOfStoreys);
        }

        private void getMinusOneNumberOfStoreys()
        {
            Building building = new Building();
            building.setNumberOfStoreys(-1);
        }

        [Fact]
        public void BigNumberMinusOneNumberOfStoreysTest()
        {
            Building building = new Building();
            building.setNumberOfStoreys(int.MaxValue - 1);

            Assert.Equal(int.MaxValue - 1, building.getNumberOfStoreys());
        }

        [Fact]
        public void BigNumberOfStoreysTest()
        {
            Building building = new Building();
            building.setNumberOfStoreys(int.MaxValue);

            Assert.Equal(int.MaxValue, building.getNumberOfStoreys());
        }

        [Fact]
        public void ValidNumberOfApartmentsTest()
        {
            Building building = new Building();
            building.setNumberOfApartments(895);

            Assert.Equal(895, building.getNumberOfApartments());
        }

        [Fact]
        public void ValidNumberOfApartmentsTest1()
        {
            Building building = new Building();
            building.setNumberOfApartments(1);

            Assert.Equal(1, building.getNumberOfApartments());
        }

        [Fact]
        public void ZeroNumberOfApartmentsTest()
        {
            Assert.Throws<ArgumentException>(getZeroNumberOfApartments);
        }

        private void getZeroNumberOfApartments()
        {
            Building building = new Building();
            building.setNumberOfApartments(0);
        }

        [Fact]
        public void MinusOneNumberOfApartmentsTest()
        {
            Assert.Throws<ArgumentException>(getMinusOneNumberOfApartments);
        }

        private void getMinusOneNumberOfApartments()
        {
            Building building = new Building();
            building.setNumberOfApartments(-1);
        }

        [Fact]
        public void BigNumberMinusOneNumberOfApartmentsTest()
        {
            Building building = new Building();
            building.setNumberOfApartments(int.MaxValue - 1);

            Assert.Equal(int.MaxValue - 1, building.getNumberOfApartments());
        }

        [Fact]
        public void BigNumberNumberOfApartmentsTest()
        {
            Building building = new Building();
            building.setNumberOfApartments(int.MaxValue);

            Assert.Equal(int.MaxValue, building.getNumberOfApartments());
        }

        [Fact]
        public void ValidNumberOfEntrancesTest()
        {
            Building building = new Building();
            building.setNumberOfEntrances(6);

            Assert.Equal(6, building.getNumberOfEntrances());
        }

        [Fact]
        public void ValidNumberOfEntrancesTest1()
        {
            Building building = new Building();
            building.setNumberOfEntrances(1);

            Assert.Equal(1, building.getNumberOfEntrances());
        }

        [Fact]
        public void ZeroNumberOfEntrancesTest()
        {
            Assert.Throws<ArgumentException>(getZeroNumberOfEntrances);
        }

        private void getZeroNumberOfEntrances()
        {
            Building building = new Building();
            building.setNumberOfEntrances(0);
        }

        [Fact]
        public void MinusOneNumberOfEntrancesTest()
        {
            Assert.Throws<ArgumentException>(getMinusOneNumberOfEntrances);
        }

        private void getMinusOneNumberOfEntrances()
        {
            Building building = new Building();
            building.setNumberOfEntrances(-1);
        }

        [Fact]
        public void BigNumberMinusOneNumberOfEntrancesTest()
        {
            Building building = new Building();
            building.setNumberOfEntrances(int.MaxValue - 1);

            Assert.Equal(int.MaxValue - 1, building.getNumberOfEntrances());
        }

        [Fact]
        public void BigNumberOfEntrancesTest()
        {
            Building building = new Building();
            building.setNumberOfEntrances(int.MaxValue);

            Assert.Equal(int.MaxValue, building.getNumberOfEntrances());
        }

        [Fact]
        public void getIdTest()
        {
            Building building = new Building();
            Building building1 = new Building();

            Assert.Equal(1, building.getId());
            Assert.Equal(2, building1.getId());
        }

        [Fact]
        public void floorHeightCalcucationsTest()
        {
            Building building = new Building();
            building.setHeight(245);
            building.setNumberOfStoreys(14);

            Assert.Equal(17.5, building.floorHeightCalculations());
        }

        [Fact]
        public void calculationNumberOfApartmentsInEntranceTest()
        {
            Building building = new Building();
            building.setNumberOfApartments(72);
            building.setNumberOfEntrances(3);

            Assert.Equal(24, building.calculationNumberOfApartmentsInEntrance());
        }

        [Fact]
        public void calculationNumberOfApartmentsPerFloorTest()
        {
            Building building = new Building();
            building.setNumberOfApartments(72);
            building.setNumberOfEntrances(3);
            building.setNumberOfStoreys(8);

            Assert.Equal(3, building.calculationNumberOfApartmentsPerFloor());
        }
    }
}
