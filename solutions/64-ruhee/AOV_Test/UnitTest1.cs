using System;
using Xunit;
using Age_of_Villagers.BangladeshiFarmers;
using System.Drawing;
using Age_of_Villagers.EgyptianKings;

namespace AOV_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void BangladeshiBackground()
        {
            BangladeshiFarmers back = new BangladeshiFarmers();
            Color b1 = back.BackgroundColor();
            Color b2 = Color.Green;
            Assert.Equal(b1, b2);
        }

        [Fact]
        public void EgyptianBackground()
        {
            EgyptianKings back = new EgyptianKings();
            Color b1 = back.BackgroundColor();
            Color b2 = Color.Yellow;
            Assert.Equal(b1, b2);
        }


    }
}
