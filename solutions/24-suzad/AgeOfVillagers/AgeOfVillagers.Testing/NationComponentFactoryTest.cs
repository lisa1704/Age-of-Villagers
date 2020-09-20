using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class NationComponentFactoryTest
    {
        [Fact]
        public void ArabBedouinComponentFactoryTesting()
        {
            Point p = new Point(100, 100);
            ArabBedouinComponentFactory arabBedouinComponentFactory = new ArabBedouinComponentFactory();
            var expected = typeof(ArabBedouinHouse);
            Assert.IsType(expected, arabBedouinComponentFactory.getComponent("House", p));
        }
    }
}
