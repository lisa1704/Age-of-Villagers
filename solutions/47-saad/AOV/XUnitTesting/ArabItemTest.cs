using System.Drawing;
using Xunit;
using AOV;

namespace XUnitTesting
{
    public class ArabItemTest
    {
        Point point = new Point(26, 34);

        [Fact]
        public void ArabHouseTest()
        {
            ArabHouse arabHouse = new ArabHouse(point);
            Assert.Equal(point, arabHouse.GetPoint());
        }

        [Fact]
        public void ArabTreeTest()
        {
            ArabTree arabTree = new ArabTree(point);
            Assert.Equal(point, arabTree.GetPoint());
        }
    }
}
