using System;
using System.Drawing;
using age_of_villagers;
using Xunit;


namespace age_of_villagers_XUnitTests
{
    public class BangladeshiTest
    {
        Graphics g;
        INation nation = new Bangladeshifarmer();
        Point housepoint = new Point(300, 300);
        [Fact]
        public void BGColorTest()
        {
            INation nation = new Bangladeshifarmer();
            Color actual = nation.BgColor();
            Color expected = Color.Green;
            Assert.Equal(expected,actual);
            
        }

        
        [Fact]
        public void getVillageTest()
        {
            INation expected = new Bangladeshifarmer();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Bangladeshi Farmers");
            actual.Equals(expected);
        }

    




    }
}
