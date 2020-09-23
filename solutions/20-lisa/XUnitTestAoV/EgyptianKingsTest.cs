using AgeOfVillagers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace UnitTestAoV
{
    [TestFixture]
    class EgyptianKingsTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase]
        public void TerrainTest()
        {
            EgyptianKings terraintest = new EgyptianKings();
            Assert.AreEqual(Color.Yellow, terraintest.SetTerrain());
        }
    }
}
