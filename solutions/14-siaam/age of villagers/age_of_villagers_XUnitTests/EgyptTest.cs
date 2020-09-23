using System;
using System.Drawing;
using age_of_villagers;
using Xunit;

namespace age_of_villagers_XUnitTests
{
    public class EgyptTest
    {
        [Fact]
        public void BGColorTest()
        {
            INation nation = new Egyptianking();
            Color actual = nation.BgColor();
            Color expected = Color.Yellow;
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void getVillageTest()
        {
            INation expected = new Egyptianking();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Egyptian king");
            actual.Equals(expected);
        }
    }
}
