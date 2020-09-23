using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Arab_Bedouin;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class ArabBedouinTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            ArabBedouin arabBedouinBackgroundColor = new ArabBedouin();
            Color actual = arabBedouinBackgroundColor.BackgroundColor();
            Color expected = Color.GreenYellow;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            ArabBedouin abTree = new ArabBedouin();
            Object actual = abTree.DrawHouse(point);
            Object expected = new ArabBedouinTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            ArabBedouin abHouse = new ArabBedouin();
            Object actual = abHouse.DrawHouse(point);
            Object expected = new ArabBedouinHouse(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WaterSourceTest()
        {
            ArabBedouin abWS = new ArabBedouin();
            Object actual = abWS.DrawWaterSource(point);
            Object expected = new NullItems();
            actual.Equals(expected);
        }
    }
}
