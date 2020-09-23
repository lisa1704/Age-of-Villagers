using System;
using System.Drawing;
using age_of_villagers;
using Xunit;

namespace age_of_villagers_XUnitTests
{
    public class ArabTest
    {
        [Fact]
        public void BGColorTest()
        {
            INation nation = new ArabBeduin();
            Color actual = nation.BgColor();
            Color expected = Color.Orange;
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void getVillageTest()
        {
            INation expected = new ArabBeduin();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Arab Beduin");
            actual.Equals(expected);
        }
    }
}
