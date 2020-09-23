using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Xunit;
namespace Age_Of_Villagers_Test
{
    class InuitHunterstest
    {
        private static string check = "Inuit Hunters";
        NationController nationController = new NationController(check);
        Point point = new Point(70, 70);

        [Fact]
        public void BDBackgroundTest()
        {
            var result = nationController.getNation(new Point()).GetTerrainColor();
            Assert.Equal(Color.White, result);
        }
        public void BDNationTest()
        {
            Assert.IsType<InuitHunters> (nationController.getNation(new Point()));

        }
        [Fact]
        public void InuitHousepointTest()
        {
            Point result = nationController.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void InuitTreepointTest()
        {


            Point result = nationController.getNation(point).GetTreePoint();
            Assert.Equal(new Point(), result);

        }
        [Fact]
        public void InuitWaterPointTest()
        {


            Point result = nationController.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }
    }
}
}
