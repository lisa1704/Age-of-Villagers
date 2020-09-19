using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class EgyptVillageItemTest
    {
        Point point = new Point(100, 100);

        [Fact]
        public void EgyptHouseItemTest()
        {
            EgyptianHouse egyptHouse = new EgyptianHouse(point);

            Assert.Equal(point, egyptHouse.GetPoint());
        }

        [Fact]
        public void EgyptTreeItemTest()
        {
            EgyptianTree egyptTree = new EgyptianTree(point);

            Assert.Equal(point, egyptTree.GetPoint());
        }

        [Fact]
        public void EgyptWaterSourceItemTest()
        {
            EgyptianWell egyptWaterSource = new EgyptianWell(point);

            Assert.Equal(point, egyptWaterSource.GetPoint());
        }
    }
}
