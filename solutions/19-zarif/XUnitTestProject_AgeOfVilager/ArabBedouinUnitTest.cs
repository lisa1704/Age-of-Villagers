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
       private string checkstring = "Arab Bedouin";

        
        Point point = new Point(100, 100);
        [Fact]
        public void ArabbackcolorTest()
        {
            NationManager man = new NationManager(checkstring);

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.GreenYellow, result);

        }

        [Fact]
        public void ArabHousepointTest()
        {


            NationManager man = new NationManager(checkstring);
            Point result = man.getNation(point).GetHousePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void ArabTreepointTest()
        {



            NationManager man = new NationManager(checkstring);
            Point result = man.getNation(point).GetTreePoint();
            Assert.Equal(point, result);

        }
        [Fact]
        public void ArabTreeWaterTest()
        {


            NationManager man = new NationManager(checkstring);

            Point result = man.getNation(point).GetWaterPoint();
            Assert.Equal(new Point(), result);

        }

        [Fact]
        public void ArabNationTest()
        {

            NationManager man = new NationManager(checkstring);
            Assert.IsType<ArabBedouin>(man.getNation(new Point()));

        }
        [Fact]
        public void ArabConstructHouseTest()
        {
            NationManager man = new NationManager(checkstring);
            Assert.IsType<ArabBedouinHouse>(man.getNation(point).GetHouse());

        }
        [Fact]
        public void ArabConstrucTreeTest()
        {
            NationManager man = new NationManager(checkstring);
            Assert.IsType<ArabBedouinTree>(man.getNation(point).GetTrees());
        }


        [Fact]
        public void ArabConstructWaterTest()
        {
            NationManager man = new NationManager(checkstring);
            Assert.IsType<NullHandler>(man.getNation(point).GetWaterSources());
        }
    }
}
