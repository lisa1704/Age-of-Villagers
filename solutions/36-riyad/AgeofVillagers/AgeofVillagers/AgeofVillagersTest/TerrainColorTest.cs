using AgeofVillagers;
using System;
using System.Drawing;
using Xunit;

namespace AgeofVillagersTest
{
    public class TerrainColorTest
    {
        [Fact]
        public void BdTerrainColor()
        {
            BangladeshiFarmers bdFarmers = new BangladeshiFarmers();
            Color actual = bdFarmers.TerrainColor();
            Color test = Color.Green;
            Assert.Equal(actual, test);
        }
    }
}
