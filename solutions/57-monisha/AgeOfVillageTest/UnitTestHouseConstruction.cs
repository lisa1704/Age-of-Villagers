using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestHouseConstruction
    {
        public Graphics g;
        Point pt = new Point(16, 16);
        /* [TestMethod]
         public void TestBangladeshiHouseConstruction()
         {           
             BangladeshiHouse BDHouseTest = new BangladeshiHouse(pt);            
             string house = BDHouseTest.CheckHouse();
             string testString = "BDHouse Constructed";

             Assert.AreEqual(house, testString);
         }*/
        [TestMethod]
        public void TestBangladeshiHouseConstruction()
        {
            BangladeshiHouse BDHouseTest = new BangladeshiHouse(pt);
            NationFactory BDObject = new NationFactory();
            //INations Ntype = BDObject.GetNation("BangladeshiFarmers");
            BangladeshiFarmers bangladeshi = new BangladeshiFarmers();
            //object house = bangladeshi.DrawHouse(g,pt);
            object house = bangladeshi.testHouse(pt);
            //string testString = "BDHouse Constructed";
            BDHouseTest.Equals(house);

        }
        [TestMethod]
        public void TestNullHouseConstruction()
        {
            INations nationType = new NullNation();
            object testObject = nationType.DrawHouse(g, pt);
            NullVillageItem NullHouseTest = new NullVillageItem(pt);

            //Assert.AreEqual(s, BDHouseTest);
            NullHouseTest.Equals(testObject);
        }
    }
}
