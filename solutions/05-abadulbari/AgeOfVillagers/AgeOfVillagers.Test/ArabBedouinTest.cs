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
    public class ArabBedouinTest
    {
        INation ab = new NationFactory("Arab Bedouin").getNation();

        [Fact]
        public void NationNameTest()
        {
            var expected = "Arab Bedouin";
            Assert.Equal(expected, ab.getNationName());
        }

        [Fact]
        public void TerrainColorTest()
        {
            var expected = Color.LightYellow;
            Assert.Equal(expected, ab.getTerrainColor());
        }

        [Fact]
        public void HouseTest()
        {
            var expected = typeof(ArabianHouse);
            Assert.IsType(expected, ab.getHouse(new Point()));
        }

        [Fact]
        public void TreeTest()
        {
            var expected = typeof(ArabianTree);
            Assert.IsType(expected, ab.getTree(new Point()));
        }

        [Fact]
        public void WatersourceTest()
        {
            var expected = typeof(NullItem);
            Assert.IsType(expected, ab.getWaterSource(new Point()));
        }
    }
}
