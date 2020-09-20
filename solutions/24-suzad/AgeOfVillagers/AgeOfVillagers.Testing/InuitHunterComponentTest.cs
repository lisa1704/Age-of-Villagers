using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class InuitHunterComponentTest
    {
        [Fact]
        public void InuitHunterHouseTest()
        {
            Point p = new Point(10, 10);
            InuitHunterHouse obj = new InuitHunterHouse(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
