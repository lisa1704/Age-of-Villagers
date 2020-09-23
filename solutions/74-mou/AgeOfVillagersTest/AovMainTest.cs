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
            Color actual = bd.TerrainColor();
            Color expected = Color.Green;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArabTerrainColorTest()
        {
            INation ab = new Arab();
            Color actual = ab.TerrainColor();
            Color expected = Color.PaleGoldenrod;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EgytianTerrainColorTest()
        {
            INation ab = new Egyptian();
            Color actual = ab.TerrainColor();
            Color expected = Color.Yellow;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InuitTerrainColorTest()
        {
            INation ab = new Inuit();
            Color actual = ab.TerrainColor();
            Color expected = Color.White;
            Assert.Equal(expected, actual);
        }

        // Type of nation test

        

    }
}
