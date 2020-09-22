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

        [Fact]
        public void ArabTerrainColor()
        {
            ArabBedouin arab = new ArabBedouin();
            Color actual = arab.TerrainColor();
            Color test = Color.LightGoldenrodYellow;
            Assert.Equal(actual, test);
        }

        [Fact]
        public void EgyptTerrainColor()
        {
            EgyptianKings egypt = new EgyptianKings();
            Color actual = egypt.TerrainColor();
            Color test = Color.Yellow;
            Assert.Equal(actual, test);
        }

        [Fact]
        public void IUnitTerrainColor()
        {
            InuitHunters iunit = new InuitHunters();
            Color actual = iunit.TerrainColor();
            Color test = Color.White;
            Assert.Equal(actual, test);
        }
    }
}
