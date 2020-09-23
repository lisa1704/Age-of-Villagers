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


        // Terrain Color of all Nation Test

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

        NationFactory nationfactory = new NationFactory();
        Graphics gr;
        Point pTest = new Point(100, 50);

        // Bangladeshi Farmers test

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

        //Arab Bedouin Test

        [Fact]
        public void ArabTest()
        {
            INation expected = nationfactory.GetNation("Arab Bedouin");
            Assert.IsType<Arab>(expected);

        }

        [Fact]
        public void ArabHouseTest()
        {
            IShapes expected = nationfactory.GetNation("Arab Bedouin").DrawHouse(gr, pTest);
            Assert.IsType<ArabHouse>(expected);
        }

        [Fact]
        public void ArabTreeTest()
        {
            IShapes expected = nationfactory.GetNation("Arab Bedouin").DrawTree(gr, pTest);
            Assert.IsType<ArabTree>(expected);
        }

        [Fact]
        public void ArabWaterSourceTest()
        {
            IShapes expected = nationfactory.GetNation("Arab Bedouin").DrawWaterSource(gr, pTest);
            Assert.IsType<NullItemSelction>(expected);
        }

        //Egyptian Kings Test
        [Fact]
        public void EgyptianTest()
        {
            INation expected = nationfactory.GetNation("Egyptian Kings");
            Assert.IsType<Egyptian>(expected);

        }

        [Fact]
        public void EgyptianHouseTest()
        {
            IShapes expected = nationfactory.GetNation("Egyptian Kings").DrawHouse(gr, pTest);
            Assert.IsType<EgyptianHouse>(expected);
        }

        [Fact]
        public void EgyptianTreeTest()
        {
            IShapes expected = nationfactory.GetNation("Egyptian Kings").DrawTree(gr, pTest);
            Assert.IsType<EgyptianTree>(expected);
        }

        [Fact]
        public void EgyptianWaterSourceTest()
        {
            IShapes expected = nationfactory.GetNation("Egyptian Kings").DrawWaterSource(gr, pTest);
            Assert.IsType<EgyptianWaterSource>(expected);
        }

        // Inuit Hunters Test
        [Fact]
        public void InuitTest()
        {
            INation expected = nationfactory.GetNation("Inuit Hunters");
            Assert.IsType<Inuit>(expected);

        }

        [Fact]
        public void InuitHouseTest()
        {
            IShapes expected = nationfactory.GetNation("Inuit Hunters").DrawHouse(gr, pTest);
            Assert.IsType<InuitHouse>(expected);
        }

        [Fact]
        public void InuitTreeTest()
        {
            IShapes expected = nationfactory.GetNation("Inuit Hunters").DrawTree(gr, pTest);
            Assert.IsType<NullItemSelction>(expected);
        }

        [Fact]
        public void InuitWaterSourceTest()
        {
            IShapes expected = nationfactory.GetNation("Inuit Hunters").DrawWaterSource(gr, pTest);
            Assert.IsType<NullItemSelction>(expected);
        }



    }
}
