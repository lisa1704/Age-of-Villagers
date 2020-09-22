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
       // NationFactory nationfactory = new NationFactory();

      /*  [TestMethod]
        public void TestBDTreeConstruction()
        {
            INations actual = nationfactory.GetNation("ArabBedouin");
            INations nationType = new ArabBedouin();
            object testObject = actual.DrawTree(g, pt);
            object BDTreeTest = new ArabTree(pt);

            BDTreeTest.Equals(testObject);
        }*/
        [TestMethod]
        public void TestNullTreeConstruction()
        {
            INations nationType = new NullNation();
            object testObject = nationType.DrawTree(g, pt);
            NullVillageItem NullTreeTest = new NullVillageItem(pt);

            NullTreeTest.Equals(testObject);
        }
       
    }
}
