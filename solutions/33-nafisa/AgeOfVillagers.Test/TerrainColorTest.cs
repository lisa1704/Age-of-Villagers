using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;
using AgeOfVillagers;



namespace AgeOfVillagers.Test
{
    [TestClass]
    public class TerrainColorTest
    {

        [TestMethod]
        public void BangladeshiFarmerTest()
        {
            BangladeshiFarmers bdTerrainColor = new BangladeshiFarmers();
            Color actual = bdTerrainColor.GetTerrainColor();
            Color expected = Color.LightGreen;
            Xunit.Assert.Equal(actual, expected);
        }
    }
}
