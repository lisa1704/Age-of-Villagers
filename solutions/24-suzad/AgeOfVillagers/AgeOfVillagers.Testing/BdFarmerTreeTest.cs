using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class BdFarmerTreeTest
    {
        [Fact]
        public void Test1()
        {
            Point p = new Point(10, 10);
            BdFarmerTree obj = new BdFarmerTree(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }
    }
}
