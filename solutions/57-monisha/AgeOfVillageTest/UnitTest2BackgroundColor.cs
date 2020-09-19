using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTest2BackgroundColor
    {
        [TestMethod]
        public void TestBangladeshiFarmer()
        {
            BangladeshiFarmers BDColor = new BangladeshiFarmers();
            Color s = BDColor.GetTerrainColor();
            Color t = Color.LightGreen;
            Assert.AreEqual(s, t);
        }
        [TestMethod]
        public void TestArabBackColor()
        {
            ArabBedouin ArabColor = new ArabBedouin();
            Color s = ArabColor.GetTerrainColor();
            Color t = Color.PaleGoldenrod;
            Assert.AreEqual(s, t);
        }
        [TestMethod]
        public void TestEgyptianBackColor()
        {
            EgyptianKings EgyptColor = new EgyptianKings();
            Color EColor = EgyptColor.GetTerrainColor();
            Color TestEColor = Color.LightGoldenrodYellow;
            Assert.AreEqual(EColor, TestEColor);
        }
        [TestMethod]
        public void TestInuitBackColor()
        {
            InuitHunters InuitColor = new InuitHunters();
            Color InuitTerrainColor = InuitColor.GetTerrainColor();
            Color TestInuitColor = Color.White;
            Assert.AreEqual(InuitTerrainColor, TestInuitColor);
        }
        [TestMethod]
        public void TestNullBackColor()
        {
            NullNation NullColor = new NullNation();
            Color NullTerrainColor = NullColor.GetTerrainColor();
            Color TestNullColor = Color.MintCream;
            Assert.AreEqual(NullTerrainColor, TestNullColor);
        }

    }
}
