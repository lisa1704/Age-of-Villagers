using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_Of_Villagers;
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
    }
}
