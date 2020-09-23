using AgeOfVillagers.Factories;
using AgeOfVillagers.Nation;
using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class EgyptianKingsTest
    {
        INation ek = new NationFactory("Egyptian Kings").getNation();

        [Fact]
        public void NationNameTest()
        {
            var expected = "Egyptian Kings";
            Assert.Equal(expected, ek.getNationName());
        }

        [Fact]
        public void TerrainColorTest()
        {
            var expected = Color.Yellow;
            Assert.Equal(expected, ek.getTerrainColor());
        }

        [Fact]
        public void HouseTest()
        {
            var expected = typeof(EgyptianHouse);
            Assert.IsType(expected, ek.getHouse(new Point()));
        }

        [Fact]
        public void TreeTest()
        {
            var expected = typeof(EgyptianTree);
            Assert.IsType(expected, ek.getTree(new Point()));
        }

        [Fact]
        public void WatersourceTest()
        {
            var expected = typeof(EgyptianWaterSource);
            Assert.IsType(expected, ek.getWaterSource(new Point()));
        }
    }
}
