using AgeOfVillagers;
using System;
using System.Drawing;
using Xunit;


namespace AgeOfVillagersTest
{
    public class AovMainTest
    {
        [Fact]
        public void AppIsRunnig()
        {
            Assert.True(8 > 5);

        }

        [Fact]
        public void TestTest()
        {
            Assert.Equal(2, 2);
        }


        // Terrain Color Test

        [Fact]
        public void BangladeshiTerrainColor()
        {
            INation bd = new Bangladeshi();
            Color expected = Color.Green;
            Color actual = bd.TerrainColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArabTerrainColor()
        {
            INation ab = new Arab();
            Color expected = Color.PaleGoldenrod;
            Color actual = ab.TerrainColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EgytianTerrainColor()
        {
            INation ab = new Egyptian();
            Color expected = Color.Yellow;
            Color actual = ab.TerrainColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InuitTerrainColor()
        {
            INation ab = new Inuit();
            Color expected = Color.White;
            Color actual = ab.TerrainColor();
            Assert.Equal(expected, actual);
        }




    }
}
