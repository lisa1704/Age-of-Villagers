using AgeOfVillagers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace UnitTestAoV
{
    [TestFixture]
    public class ArabBedouinTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase]
        public void TerrainTest()
        {
            BangladeshiFarmers terraincolortest = new BangladeshiFarmers();
            Color actual = terraincolortest.SetTerrain();
            Color expected = Color.LightYellow;
        }
    }
}
