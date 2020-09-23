using System;
using System.Drawing;
using age_of_villagers;
using Xunit;

namespace age_of_villagers_XUnitTests
{
    public class InuitTest
    {
        [Fact]
        public void BGColorTest()
        {
            INation nation = new Inuithunter();
            Color actual = nation.BgColor();
            Color expected = Color.White;
            Assert.Equal(expected, actual);

        }


       
    }
}
