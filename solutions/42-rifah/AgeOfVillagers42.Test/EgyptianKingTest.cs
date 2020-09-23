using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers.Egyptian_Kings;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class EgyptianKingTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            EgyptianKings egyptianKingsBackgroundColor = new EgyptianKings();
            Color actual = egyptianKingsBackgroundColor.BackgroundColor();
            Color expected = Color.Yellow;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            EgyptianKings ekTree = new EgyptianKings();
            Object actual = ekTree.DrawTree(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            EgyptianKings ekHouse = new EgyptianKings();
            Object actual = ekHouse.DrawHouse(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WatersourceTest()
        {
            EgyptianKings ekWS = new EgyptianKings();
            Object actual = ekWS.DrawWaterSource(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }
    }
}
