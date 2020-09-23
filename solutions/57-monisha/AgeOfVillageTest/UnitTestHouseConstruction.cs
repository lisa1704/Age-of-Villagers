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
            BangladeshiFarmers bangladeshi = new BangladeshiFarmers();
            object house = bangladeshi.testHouse(pt);
            BDHouseTest.Equals(house);
        }
        [TestMethod]
        public void TestArabHouseConstruction()
        {
            ArabBedouinHouse ArabHouseTest = new ArabBedouinHouse(pt);
        
            ArabBedouin arab = new ArabBedouin();
            object house = arab.testHouse(pt);
            ArabHouseTest.Equals(house);
        }
        [TestMethod]
        public void TestEgyptHouseConstruction()
        {
            EgyptianHouse EgyptianHouseTest = new EgyptianHouse(pt);

            EgyptianKings egyptian = new EgyptianKings();
            object house = egyptian.testHouse(pt);
            EgyptianHouseTest.Equals(house);
        }

        [TestMethod]
        public void TestInuitHouseConstruction()
        {
            InuitHouse InuitHouseTest = new InuitHouse(pt);

            InuitHunters inuit = new InuitHunters();
            object house = inuit.testHouse(pt);
            InuitHouseTest.Equals(house);
        }

        [TestMethod]
        public void TestNullHouseConstruction()
        {
            INations nationType = new NullNation();
            object testObject = nationType.DrawHouse(g, pt);
            NullVillageItem NullHouseTest = new NullVillageItem(pt);

            NullHouseTest.Equals(testObject);
        }
    }
}
