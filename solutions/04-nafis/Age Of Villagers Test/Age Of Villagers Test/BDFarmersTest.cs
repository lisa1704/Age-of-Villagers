using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Xunit;

namespace Age_Of_Villagers_Test
{
    public class BDFarmersTest
    {
        private static string check = "Bangladeshi Farmers";
        NationController nationController = new NationController(check);
        Point point = new Point(70,70);
        
        [Fact]
        public void BDBackgroundTest()
        {
            var result = man.getNation(new Point()).GetTerrainColor();
            Assert.Equal(Color.LightGreen, result);
        }
    }

}
