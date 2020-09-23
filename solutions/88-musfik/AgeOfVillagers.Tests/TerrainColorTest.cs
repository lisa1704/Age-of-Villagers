﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Tests
{
    public class TerrainColorTest
    {
        [Fact]
        public void Arab_TerrainColorTest()
        {
            INation nation = new ArabBedouin();
            var expected = Color.LightGoldenrodYellow;
            var actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BD_TerrainColorTest()
        {
            INation nation = new BangladeshiFarmers();
            var expected = Color.GreenYellow;
            var actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


    }
}
