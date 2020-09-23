using System;
using System.Drawing;
using age_of_villagers;
using Xunit;


namespace age_of_villagers_XUnitTests
{
    public class BangladeshiTest
    {
        [Fact]
        public void ColorTest()
        {
            INation nation = new Bangladeshifarmer();
            Color actual = nation.BgColor();
            Color expected = Color.Green;
            Assert.Equal(expected,actual);
            
        }
    }
}
