using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class ArabVillageItemTest
    {
        Point point = new Point(100, 100);

        [Fact]
        public void ArabHouseItemTest()
        {
            ArabHouse arabHouse = new ArabHouse(point);

            Assert.Equal(point, arabHouse.GetPoint());
        }

        [Fact]
        public void ArabTreeItemTest()
        {
            ArabTree arabTree = new ArabTree(point);

            Assert.Equal(point, arabTree.GetPoint());
        }
    }
}
