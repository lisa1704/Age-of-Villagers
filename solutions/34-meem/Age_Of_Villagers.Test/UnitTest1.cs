using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;
using System.Drawing;

namespace Age_Of_Villagers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBDTerrainColor()
        {
            BangladeshiNation bd = new BangladeshiNation();
            Color color = bd.getColor();
            Assert.AreEqual(Color.Green, color);


        }

        [TestMethod]
        public void TestArabTerrainColor()
        {
            ArabBedouinNation arab  = new ArabBedouinNation();
            Color color = arab.getColor();
            Assert.AreEqual(Color.YellowGreen, color);


        }

    }
}
