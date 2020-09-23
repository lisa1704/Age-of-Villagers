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
        public void TestBangladeshiTreeConstruction()
        {
            BangladeshiTree BDTreeTest = new BangladeshiTree(pt);

            BangladeshiFarmers BD = new BangladeshiFarmers();
            object tree = BD.testTree(pt);
            BDTreeTest.Equals(tree);
        }

        [TestMethod]
        public void TestArabTreeConstruction()
        {
            ArabTree ArabTreeTest = new ArabTree(pt);

            ArabBedouin arab = new ArabBedouin();
            object tree = arab.testTree(pt);
            ArabTreeTest.Equals(tree);
        }

        [TestMethod]
        public void TestEgyptTreeConstruction()
        {
            EgyptianTree EgyptTreeTest = new EgyptianTree(pt);

            EgyptianKings egyptian = new EgyptianKings();
            object tree = egyptian.testTree(pt);
            EgyptTreeTest.Equals(tree);
        }

        [TestMethod]
        public void TestInuitTreeConstruction()
        {
            INations nationType = new InuitHunters();
            object testObject = nationType.DrawTree(g, pt);
            NullVillageItem InuitTreeTest = new NullVillageItem(pt);

            InuitTreeTest.Equals(testObject);
        }

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
