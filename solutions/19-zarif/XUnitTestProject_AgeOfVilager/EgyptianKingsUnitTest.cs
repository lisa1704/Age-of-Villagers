using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;

using System.Drawing;
using Xunit;

namespace XUnitTestProject_AgeOfVilager
{
   public class EgyptianKingsUnitTest
    {
        private static string  checkstring = "Egyptian Kings";

        NationManager man = new NationManager(checkstring);

        Point point = new Point(100, 100);
        [Fact]
        public void EgyptbackcolorTest()
        {

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.Yellow, result);

        }


        [Fact]
        public void EgyptHousepointTest()
        {
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void EgyptTreepointTest()
        {

          
            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void EgyptWaterTest()
        {


            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(point, result);

        }

        [Fact]
        public void EgyptNationTest()
        {

            Assert.IsType<EgyptianKings>(man.getNation(new Point()));

        }
        [Fact]
        public void EgyptConstructHouseTest()
        {
           
            Assert.IsType<EgyptianKingsHouse>(man.getNation(point).GetHouse());

        }
        [Fact]
        public void EgyptConstrucTreeTest()
        {
            Assert.IsType<EgyptianKingsTree>(man.getNation(point).GetTrees());
        }


        [Fact]
        public void EgyptConstructWaterTest()
        {
            Assert.IsType<EgyptianKingsWaterSource>(man.getNation(point).GetWaterSources());
        }
    }


}
