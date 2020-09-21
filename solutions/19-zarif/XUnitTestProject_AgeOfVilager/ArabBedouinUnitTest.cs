using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;

using System.Drawing;
using Xunit;
namespace XUnitTestProject_AgeOfVilager
{
    public class ArabBedouinUnitTest
    {
       private static string checkstring = "Arab Bedouin";

        NationManager man = new NationManager(checkstring);
        Point point = new Point(100, 100);
        [Fact]
        public void ArabbackcolorTest()
        {
           

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.GreenYellow, result);

        }

        
        [Fact]
        public void ArabHousepointTest()
        {


     
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void ArabTreepointTest()
        {



            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void ArabTreeWaterTest()
        {


          
            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }

        [Fact]
        public void ArabNationTest()
        {

           
            Assert.IsType<ArabBedouin>(man.getNation(new Point()));

        }
        [Fact]
        public void ArabConstructHouseTest()
        {
          
            Assert.IsType<ArabBedouinHouse>(man.getNation(point).GetHouse());

        }
        [Fact]
        public void ArabConstrucTreeTest()
        {
           
            Assert.IsType<ArabBedouinTree>(man.getNation(point).GetTrees());
        }


        [Fact]
        public void ArabConstructWaterTest()
        {
            
            Assert.IsType<NullHandler>(man.getNation(point).GetWaterSources());
        }
    }
}
