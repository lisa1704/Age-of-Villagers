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
            var result = nationController.getNation(new Point()).GetTerrainColor();
            Assert.Equal(Color.LightGreen, result);
        }
        [Fact]
        public void BDNationTest()
        {
            Assert.IsType<BangladeshiFarmers>(nationController.getNation(new Point()));

        }
        [Fact]
        public void BDHousepointTest()
        {
            Point result = nationController.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreepointTest()
        {


            Point result = nationController.getNation(point).GetTreePoint();
            Assert.Equal(new Point(), result);

        }
        [Fact]
        public void BDWaterPointTest()
        {


            Point result = nationController.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }
    }
}
