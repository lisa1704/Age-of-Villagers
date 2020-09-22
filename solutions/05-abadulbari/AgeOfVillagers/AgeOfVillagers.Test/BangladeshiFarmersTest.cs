using AgeOfVillagers.Factories;
using AgeOfVillagers.Nation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class BangladeshiFarmersTest
    {
        INation bd = new NationFactory("Bangladeshi Farmers").getNation();

        [Fact]
        public void NationNameTest()
        {
            var expected = "Bangladeshi Farmers";
            Assert.Equal(expected, bd.getNationName());
        }

        [Fact]
        public void TerrainColorTest()
        {
            var expected = Color.Green;
            Assert.Equal(expected, bd.getTerrainColor());
        }
    }
}
