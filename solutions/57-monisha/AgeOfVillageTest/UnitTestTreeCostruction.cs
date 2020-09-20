using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestTreeCostruction
    {
        public Graphics g;
        Point pt = new Point(16, 16);
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestNullTreeConstruction()
        {
            INations nationType = new NullNation();
            object testObject = nationType.DrawTree(g, pt);
            NullVillageItem NullTreeTest = new NullVillageItem(pt);

            //Assert.AreEqual(s, BDHouseTest);
            NullTreeTest.Equals(testObject);
        }
    }
}
