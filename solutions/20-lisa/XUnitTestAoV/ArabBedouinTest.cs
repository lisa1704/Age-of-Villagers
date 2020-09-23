using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTestAoV
{

    public class ArabBedouinTest
    {
        NationFactory naF = new NationFactory();
        [Fact]
        public void TerrainTest()
        {
            Arabs terraincolortest = new Arabs();
            Color actual = terraincolortest.SetTerrain();
            Color expected = Color.LightYellow;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ArabNationNameTest()
        {
            INation expected = naF.GetNation("Arab Bedouin");
            Assert.IsType<Arabs>(expected);
        }
    }
}
