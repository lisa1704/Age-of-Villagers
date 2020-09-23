﻿using System;
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
            Color expected = bdTerrainColor.PaintTerrain();
            Color actual = Color.LightGreen;
            Xunit.Assert.Equal(actual, expected);
        }

        
        
    }
}
