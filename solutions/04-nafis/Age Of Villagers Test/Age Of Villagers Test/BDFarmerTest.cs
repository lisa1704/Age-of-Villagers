using System;
using System.Collections.Generic;
using System.Text;
using Age_Of_Villagers_Test;

using System.Drawing;
using Xunit;

namespace XUnitTestProject_AgeOfVilager
{
    public class BangladeshiFarmersUnitTest
    {
        private static string checkstring = "Bangladeshi Farmers";
        NationController man = new NationController(checkstring);
        Point point = new Point(100, 100);
        [Fact]
        public void BDbackcolorTest()
        {
            var result = man.getNation(new Point()).GetTerritoryColor();
            Assert.Equal(Color.Green, result);

        }
    }
}