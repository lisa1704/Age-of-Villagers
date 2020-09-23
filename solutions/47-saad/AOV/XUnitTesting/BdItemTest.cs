using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;
using AOV;

namespace XUnitTesting
{
    public class BdItemTest
    {
        Point point = new Point(100, 100);
        [Fact]
        public void BdHouseTest()
        {
            BdHouse bdHouse = new BdHouse(point);
            Assert.Equal(point, bdHouse.GetPoint());
        }
    }
}
