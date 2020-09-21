using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;

using System.Drawing;
using Xunit;

namespace XUnitTestProject_AgeOfVilager
{
   public class BangladeshiFarmersUnitTest
    {
        [Fact]
        public void BDbackcolorTest()
        {
            string checkstring = "Bangladeshi Farmers";
            NationManager man = new NationManager(checkstring);

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.Green, result);

        }

        [Fact]
        public void BDHousepointTest()
        {
            string checkstring = "Bangladeshi Farmers";
            NationManager man = new NationManager(checkstring);

            Point point = new Point(10,10);
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreepointTest()
        {
            string checkstring = "Bangladeshi Farmers";
            NationManager man = new NationManager(checkstring);

            Point point = new Point(10, 10);
            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
    }
}
