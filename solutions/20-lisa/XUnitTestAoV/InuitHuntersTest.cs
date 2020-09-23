﻿using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTestAoV
{

    public class InuitHuntersTest
    {
        NationFactory naF = new NationFactory();
     
        [Fact]
        public void InuitTerrainTest()
        {
            InuitHunters inTerrainTest = new InuitHunters();
            Assert.Equal(Color.White, inTerrainTest.SetTerrain());
        }
        [Fact]
        public void InuitNationNameTest()
        {
            INation expected = naF.GetNation("Inuit Hunters");
            Assert.IsType<InuitHunters>(expected);
        }
    }
}