using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;

using System.Drawing;
using Xunit;

namespace XUnitTestProject_AgeOfVilager
{
   public class InuitHuntersUnitTest
    {
        private static string checkstring = "Inuit Hunters";

        NationManager man = new NationManager(checkstring);

        Point point = new Point(100, 100);
        [Fact]
        public void InuitbackcolorTest()
        {

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.White, result);

        }


        [Fact]
        public void InuitHousepointTest()
        {
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void InuitTreepointTest()
        {


            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(new Point(), result);

        }
        [Fact]
        public void InuitWaterTest()
        {


            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }

        [Fact]
        public void InuitNationTest()
        {

            Assert.IsType<InuitHunters>(man.getNation(new Point()));

        }
        [Fact]
        public void InuitHouseTest()
        {

            Assert.IsType<InuitHuntersHouse>(man.getNation(point).GetHouse());

        }
        [Fact]
        public void InuitConstrucTreeTest()
        {
            Assert.IsType<NullHandler>(man.getNation(point).GetTrees());
        }


        [Fact]
        public void InuitConstructWaterTest()
        {
            Assert.IsType<NullHandler>(man.getNation(point).GetWaterSources());
        }
    }


}
