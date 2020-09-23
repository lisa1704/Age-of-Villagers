using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Xunit;

namespace Age_Of_Villagers_Test
{
    public class ArabBedouinTest
    {
        private static string check = "Arab Bedouin";
        NationController nationController = new NationController(check);
        Point point = new Point(70, 70);

        [Fact]
        public void BDBackgroundTest()
        {
            var result = nationController.getNation(new Point()).GetTerrainColor();
            Assert.Equal(Color.LightGoldenrodYellow, result);
        }
        [Fact]
        public void BDNationTest()
        {
            Assert.IsType<ArabBedouin> (nationController.getNation(new Point()));

        }
    }
}
