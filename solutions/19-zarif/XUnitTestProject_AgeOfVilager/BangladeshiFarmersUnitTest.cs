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
        string checkstring = "Bangladeshi Farmers";
        [Fact]
        public void BDbackcolorTest()
        {
            
            NationManager man = new NationManager(checkstring);

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.Green, result);

        }

        [Fact]
        public void BDHousepointTest()
        {
            
            NationManager man = new NationManager(checkstring);

            Point point = new Point(10, 10);
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreepointTest()
        {
           
            NationManager man = new NationManager(checkstring);

            Point point = new Point(10, 10);
            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void BDTreeWaterTest()
        {
           
            NationManager man = new NationManager(checkstring);

            Point point = new Point(10, 10);
            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(point, result);

        }

        [Fact]
        public void BDNationTest()
        {
         
            NationManager man = new NationManager(checkstring);


            Assert.IsType<BangladeshiFarmers>(man.getNation(new Point()));

        }
        [Fact]
        public void BDConstructHouseTest()
        {
      
            NationManager man = new NationManager(checkstring);
           

            Assert.IsType<BdFarmerHouse>(man.getNation(new Point(200, 200)).GetHouse());

        }
        [Fact]
        public void BDConstrucTreeTest()
        {

            NationManager man = new NationManager(checkstring);


            Assert.IsType<BdFarmerTree>(man.getNation(new Point(200, 200)).GetTrees());
        }


        [Fact]
        public void BDConstructWaterTest()
        {

            NationManager man = new NationManager(checkstring);


            Assert.IsType<BdFarmerWaterSc>(man.getNation(new Point(200, 200)).GetWaterSources()  );

        }
    }
}