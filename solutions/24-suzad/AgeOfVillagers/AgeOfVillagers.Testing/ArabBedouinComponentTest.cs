using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class ArabBedouinComponentTest
    {
        [Fact]
        public void ArabBedouinHouseTest()
        {
            Point p = new Point(10, 10);
            ArabBedouinHouse obj = new ArabBedouinHouse(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }

        [Fact]
        public void ArabBedouinTreeTest()
        {
            Point p = new Point(10, 10);
            ArabBedouinTree obj = new ArabBedouinTree(p);
            Point actual = obj.getPoint();
            Assert.Equal(actual, p);
        }

    }
}
