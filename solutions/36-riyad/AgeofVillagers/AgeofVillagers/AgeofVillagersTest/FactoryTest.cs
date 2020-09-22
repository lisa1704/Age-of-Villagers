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
    }
}
