using System.Drawing;
using Xunit;
using AOV;

namespace XUnitTesting
{
    public class InuitItemTest
    {
        Point point = new Point(26, 34);

        [Fact]
        public void InuitHouseTest()
        {

            InuitHouse igloo = new InuitHouse(point);
            Assert.Equal(point, igloo.GetPoint());
        }       
    }
}
