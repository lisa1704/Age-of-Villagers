using System;
using Xunit;
using System.Drawing;
using Age_of_Villagers.Nation;
using Age_of_Villagers.House;

namespace Age_of_Villagers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Initial_test()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void BangladeshiTerrainColor()
        {
            string name = "Bangladeshi Farmers" ;
            INation nation = new BangladeshiFarmer(name);
            Color expected = Color.PaleGreen;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }
    }
}
