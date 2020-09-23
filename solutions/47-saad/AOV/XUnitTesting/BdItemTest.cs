using System.Drawing;
using Xunit;
using AOV;

namespace XUnitTesting
{
    public class BdItemTest
    {
        Point point = new Point(26, 34);
        [Fact]
        public void BdHouseTest()
        {
            BdHouse bdHouse = new BdHouse(point);
            Assert.Equal(point, bdHouse.GetPoint());
        }
    }
}
