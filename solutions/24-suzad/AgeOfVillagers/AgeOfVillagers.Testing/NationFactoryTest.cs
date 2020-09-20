using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Testing
{
    public class NationFactoryTest
    {
        [Fact]
        public void NationAbstractFactoryTesting()
        {
            NationFactory nationFactory = new NationFactory();
            var actual = nationFactory.getNation("Bangladeshi Farmer");
            var expected = typeof(BdFarmerNation);
            Assert.IsType(expected, actual);
        }
    }
}
