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
        public void TestMethod1()
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

    }
}
