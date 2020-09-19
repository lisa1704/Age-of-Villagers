using System;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class BdFarmerHouseTest
    {
        [Fact]
        public void Test1()
        {
            Point p = new Point(10, 10);
            BdFarmerHouse obj = new BdFarmerHouse(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
