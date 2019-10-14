using System;
using Xunit;
using BuildingProg;

namespace TestBuilding
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Building building = new Building();
            building.setHeight(156);

            building.getBuildingInfo();
        }
    }
}
