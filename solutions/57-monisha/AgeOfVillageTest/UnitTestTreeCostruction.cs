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
        public void TestBangladeshiTreeConstruction()
        {
            INations BDTree = new NullNation();
            object s = BDTree.DrawTree(g, pt);
            NullVillageItem BDHouseTest = new NullVillageItem(pt);

            //Assert.AreEqual(s, BDHouseTest);
            BDHouseTest.Equals(s);
        }
    }
}
