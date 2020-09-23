using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTestAoV
{
    public class EgyptianKingsTest
    {
        NationFactory naF = new NationFactory();
        [Fact]
        public void TerrainTest()
        {
            EgyptianKings terraintest = new EgyptianKings();
            Assert.Equal(Color.Yellow, terraintest.SetTerrain());
        }
        [Fact]
        public void EgyptianNationNameTest()
        {
            INation expected = naF.GetNation("Egyptian Kings");
            Assert.IsType<EgyptianKings>(expected);
        }
    }
}
