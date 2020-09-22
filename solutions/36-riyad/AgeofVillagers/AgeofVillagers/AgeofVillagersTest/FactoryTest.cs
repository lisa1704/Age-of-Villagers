using System;
using System.Collections.Generic;
using System.Text;
using AgeofVillagers;
using Xunit;

namespace AgeofVillagersTest
{
    public class FactoryTest
    {
        [Fact]
        public void BdNationFactory()
        {
            FactoryPattern nationFactory = new FactoryPattern();
            var actual = nationFactory.GetNation("BangladeshiFarmers");
            var expected = typeof(BangladeshiFarmers);
            Assert.IsType(expected, actual);

        }

        [Fact]
        public void ArabationFactory()
        {
            FactoryPattern nationFactory = new FactoryPattern();
            var actual = nationFactory.GetNation("ArabBedouin");
            var expected = typeof(ArabBedouin);
            Assert.IsType(expected, actual);

        }

        [Fact]
        public void EgyptNationFactory()
        {
            FactoryPattern nationFactory = new FactoryPattern();
            var actual = nationFactory.GetNation("EgyptianKings");
            var expected = typeof(EgyptianKings);
            Assert.IsType(expected, actual);

        }
    }
}
