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
    public class InuitHuntersTest
    {
        INation ih = new NationFactory("Inuit Hunters").getNation();

        [Fact]
        public void NationNameTest()
        {
            var expected = "Inuit Hunters";
            Assert.Equal(expected, ih.getNationName());
        }

        [Fact]
        public void TerrainColorTest()
        {
            var expected = Color.White;
            Assert.Equal(expected, ih.getTerrainColor());
        }

        [Fact]
        public void HouseTest()
        {
            var expected = typeof(InuitHouse);
            Assert.IsType(expected, ih.getHouse(new Point()));
        }

        [Fact]
        public void TreeTest()
        {
            var expected = typeof(NullItem);
            Assert.IsType(expected, ih.getTree(new Point()));
        }

        [Fact]
        public void WatersourceTest()
        {
            var expected = typeof(NullItem);
            Assert.IsType(expected, ih.getWaterSource(new Point()));
        }
    }
}
