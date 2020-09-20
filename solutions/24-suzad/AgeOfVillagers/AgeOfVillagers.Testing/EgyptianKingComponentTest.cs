using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class EgyptianKingComponentTest
    {
        [Fact]
        public void EgyptianKingHouseTest()
        {
            Point p = new Point(10, 10);
            EgyptianKingHouse obj = new EgyptianKingHouse(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
