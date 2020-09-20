using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class NullVillageComponentTest
    {
        [Fact]
        public void NullVillageComponentTesting()
        {
            Point p = new Point();
            NullVillageComponent obj = new NullVillageComponent();
            Point actual = obj.getPoint();
            Point expected = p;
            Assert.Equal(expected, actual);
        }
    }
}
