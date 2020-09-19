using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class BangladeshiVillageItemTest
    {
        Point point = new Point(100, 100);

        [Fact]
        public void BangladeshiHouseItemTest()
        {
            BangladeshiHouse bangladeshiHouse = new BangladeshiHouse(point);

            Assert.Equal(point, bangladeshiHouse.GetPoint());
        }

        [Fact]
        public void BangladeshiTreeItemTest()
        {
            BangladeshiTree bangladeshiTree = new BangladeshiTree(point);

            Assert.Equal(point, bangladeshiTree.GetPoint());
        }

        [Fact]
        public void BangladeshiWaterSourceItemTest()
        {
            BangladeshiPond bangladeshiWaterSource = new BangladeshiPond(point);

            Assert.Equal(point, bangladeshiWaterSource.GetPoint());
        }
    }
}
