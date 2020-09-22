using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestArabBBox
    {
        public Graphics g;
        Point pt = new Point(100, 80);
        [TestMethod]
        public void TestTreeBBox()
        {
            //INations actual = nationfactory.GetNation("ArabBedouin");
            ArabTree TreeType = new ArabTree(pt);
            int TestTreeBBox = TreeType.GetBBox();
            Assert.AreEqual(TestTreeBBox, (16 * 12));
        }
    }
}
