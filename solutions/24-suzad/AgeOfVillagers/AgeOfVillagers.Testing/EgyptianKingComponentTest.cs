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

        [Fact]
        public void EgyptianKingTreeTest()
        {
            Point p = new Point(10, 10);
            EgyptianKingTree obj = new EgyptianKingTree(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }

        [Fact]
        public void EgyptianKingRiverTest()
        {
            Point p = new Point(10, 10);
            EgyptianKingRiver obj = new EgyptianKingRiver(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
