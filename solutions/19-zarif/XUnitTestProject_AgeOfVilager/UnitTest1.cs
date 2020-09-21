using AgeOfVillagers;
using System;
using System.Drawing;
using Xunit;
namespace XUnitTestProject_AgeOfVilager
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int value1 = 2;
            int value2 = 2;

            var result = value1 + value2;

            Assert.Equal(4, result);

        }
        [Fact]
        public void ColorcheckTest_01()
        {
            string checkstring = "Arab Bedouin";
            NationManager man = new NationManager(checkstring) ;

            var result =  man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.GreenYellow,result);

        }
    
      
        [Fact]
        public void ColorcheckTest_03()
        {
            string checkstring = "Inuit Hunters";
            NationManager man = new NationManager(checkstring);

            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.White, result);

        }

    }
}
