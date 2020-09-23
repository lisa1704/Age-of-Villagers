using System.Drawing;
using Xunit;
using AOV;

namespace XUnitTesting
{
    public class EgyptItemTest
    {
        Point point = new Point(26, 34);

        [Fact]
        public void EgyptHouseTest()
        {
            EgyptHouse egyptHouse = new EgyptHouse(point);
            Assert.Equal(point, egyptHouse.GetPoint());
        }

        [Fact]
        public void EgyptTreeTest()
        {
            EgyptTree egyptTree = new EgyptTree(point);
            Assert.Equal(point, egyptTree.GetPoint());
        }

        [Fact]
        public void EgyptWaterTest()
        {
            EgyptWater egyptWater = new EgyptWater(point);
            Assert.Equal(point, egyptWater.GetPoint());
        }
    }
}
