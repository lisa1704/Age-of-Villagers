using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class NoVillageItemTest
    {
        Point point = new Point(100, 100);

        [Fact]
        public void NoTreeItemTest()
        {
            NoTree noTree = new NoTree(point);

            Assert.Equal(point, noTree.GetPoint());
        }

        [Fact]
        public void NoWaterSourceItemTest()
        {
            NoWaterResource noWaterSource = new NoWaterResource(point);

            Assert.Equal(point, noWaterSource.GetPoint());
        }
    }
}
