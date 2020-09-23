using AgeOfVillagers;
using System;
using System.Drawing;
using Xunit;
using Xunit.Sdk;

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

        // Bangladeshi Farmers test
        NationFactory nationfactory = new NationFactory();
        Graphics gr;
        Point pTest = new Point(100, 50);

        [Fact]
        public void BangladeshiTest()
        {
            INation expected = nationfactory.GetNation("Bangladeshi Farmers");
            Assert.IsType<Bangladeshi>(expected);

        }

        [Fact]
        public void BangladeshiHouseTest()
        {
            IShapes expected = nationfactory.GetNation("Bangladeshi Farmers").DrawHouse(gr, pTest);
            Assert.IsType<BangladeshiHouse>(expected);
        }

        [Fact]
        public void BangladeshiTreeTest()
        {
            IShapes expected = nationfactory.GetNation("Bangladeshi Farmers").DrawTree(gr, pTest);
            Assert.IsType<BangladeshiTree>(expected);
        }

        [Fact]
        public void BangladeshiWaterSourceTest()
        {
            IShapes expected = nationfactory.GetNation("Bangladeshi Farmers").DrawWaterSource(gr, pTest);
            Assert.IsType<BangladeshiWaterSource>(expected);
        }


    }
}
