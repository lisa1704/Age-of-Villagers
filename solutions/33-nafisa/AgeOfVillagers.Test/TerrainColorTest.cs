using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using Xunit;



namespace AgeOfVillagers.Test
{
   
    public class TerrainColorTest
    {

        [Fact]
        public void BangladeshiFarmerTest()
        {
            BangladeshiFarmers bdTerrainColor = new BangladeshiFarmers();
            Color actual = bdTerrainColor.GetTerrainColor();
            Color expected = Color.Green;
            Xunit.Assert.Equal(actual, expected);
        }

        //[TestMethod]
        
    }
}
