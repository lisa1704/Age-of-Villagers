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
        Point pt = new Point(100, 80);
        [TestMethod]
        public void TestBDTreeConstruction()
        {
            INations nationType = new ArabBedouin();
            object testObject = nationType.DrawTree(g, pt);
            CompositeShape BDTreeTest = new ArabTree(pt);

            //Assert.AreEqual(s, BDHouseTest);
            BDTreeTest.Equals(testObject);
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
