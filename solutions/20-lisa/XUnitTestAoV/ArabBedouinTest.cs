﻿using AgeOfVillagers;
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
            Arabs terraincolortest = new Arabs();
            Color actual = terraincolortest.SetTerrain();
            Color expected = Color.LightYellow;
        }
    }
}