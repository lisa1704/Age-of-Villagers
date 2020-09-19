using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class InuitVillageItemTest
    {
        Point point = new Point(100, 100);

        [Fact]
        public void InuitHouseItemTest()
        {
            IglooHouse inuitbHouse = new IglooHouse(point);

            Assert.Equal(point, inuitbHouse.GetPoint());
        }
    }
}
