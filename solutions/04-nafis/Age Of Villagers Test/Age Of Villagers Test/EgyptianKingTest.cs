using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Xunit;
namespace Age_Of_Villagers_Test
{
    public class EgyptianKingTest
    {
        private static string check = "Egyptian Kings";
        NationController nationController = new NationController(check);
        Point point = new Point(70, 70);

        [Fact]
        public void BDBackgroundTest()
        {
            var result = nationController.getNation(new Point()).GetTerrainColor();
            Assert.Equal(Color.Yellow, result);
        }
        [Fact]
        public void BDNationTest()
        {
            Assert.IsType<EgyptianKings> (nationController.getNation(new Point()));

        }
        [Fact]
        public void EgyptHousepointTest()
        {
            Point result = nationController.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void EgyptTreepointTest()
        {


            Point result = nationController.getNation(point).GetTreePoint();
            Assert.Equal(new Point(), result);

        }
        [Fact]
        public void EgyptWaterPointTest()
        {


            Point result = nationController.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }

    }
}
