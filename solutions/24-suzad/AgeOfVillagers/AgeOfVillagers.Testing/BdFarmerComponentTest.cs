using System;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class BdFarmerComponentTest
    {
        [Fact]
        public void BdFarmerHouseTest()
        {
            Point p = new Point(10, 10);
            BdFarmerHouse obj = new BdFarmerHouse(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }

        [Fact]
        public void BdFarmerTreeTest()
        {
            Point p = new Point(10, 10);
            BdFarmerTree obj = new BdFarmerTree(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }

        [Fact]
        public void BdFarmerRiverTest()
        {
            Point p = new Point(10, 10);
            BdFarmerRiver obj = new BdFarmerRiver(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
