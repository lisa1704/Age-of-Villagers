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
        private static string checkstring = "Bangladeshi Farmers";
        NationManager man = new NationManager(checkstring);
        Point point = new Point(100, 100);
        [Fact]
        public void BDbackcolorTest()
        {
            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.Green, result);

        }

        [Fact]
        public void BDHousepointTest()
        {
            
          

            
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreepointTest()
        {
           
            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreeWaterTest()
        {
           
            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(point, result);

        }

        [Fact]
        public void BDNationTest()
        {
         
     


            Assert.IsType<BangladeshiFarmers>(man.getNation(new Point()));

        }
        [Fact]
        public void BDConstructHouseTest()
        {
      
      
           

            Assert.IsType<BdFarmerHouse>(man.getNation(new Point(200, 200)).GetHouse());

        }
        [Fact]
        public void BDConstrucTreeTest()
        {

           


            Assert.IsType<BdFarmerTree>(man.getNation(new Point(200, 200)).GetTrees());
        }


        [Fact]
        public void BDConstructWaterTest()
        {



            Assert.IsType<BdFarmerWaterSc>(man.getNation(new Point(200, 200)).GetWaterSources());

        }
    }
}