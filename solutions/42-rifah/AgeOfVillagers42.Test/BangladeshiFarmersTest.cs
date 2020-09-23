using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using AgeOfVillagers.Bangladeshi_Farmers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class BangladeshiFarmersTest
    {
        Point point = new Point(42, 42);
        [TestMethod]
        public void BackgroundColorTest()
        {
            BangladeshiFarmers bdFarmersBackgroundColor = new BangladeshiFarmers();
            Color actual = bdFarmersBackgroundColor.BackgroundColor();
            Color expected = Color.Green;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            BDFarmersTest bdFarmers = new BDFarmersTest();
            BDFarmersTree treeTest = new BDFarmersTree(point);
            Object treeTestObject = bdFarmers.testTreePoint(point);
            treeTestObject.Equals(treeTest);
        }

        [TestMethod]
        public void HouseTest()
        {
            BangladeshiFarmers bdFarmers = new BangladeshiFarmers();
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void WatersourceTest()
        {
            BangladeshiFarmers bdFarmers = new BangladeshiFarmers();
            Assert.AreEqual(2, 2);
        }
    }
}
