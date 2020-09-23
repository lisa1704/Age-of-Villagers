using AgeOfVillagers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace UnitTestAoV
{
    [TestFixture]
    public class InuitHuntersTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase]
        public void InuitTerrainTest()
        {
            InuitHunters inTerrainTest = new InuitHunters();
            Assert.AreEqual(Color.White, inTerrainTest.SetTerrain());
        }
    }
}
