using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestWaterRourseConstruction
    {
        public Graphics g;
        Point pt = new Point(100, 80);

        [TestMethod]
        public void TestBDWaterSourceConstruction()
        {
            BangladeshiWaterSource BDWaterTest = new BangladeshiWaterSource(pt);

            BangladeshiFarmers BD = new BangladeshiFarmers();
            object water = BD.testWaterSource(pt);
            BDWaterTest.Equals(water);
        }
        [TestMethod]
        public void TestEgyptWaterSourceConstruction()
        {
            EgyptianWaterSource EgyptWaterTest = new EgyptianWaterSource(pt);

            EgyptianKings egyptian = new EgyptianKings();
            object water = egyptian.testWaterSource(pt);
            EgyptWaterTest.Equals(water);
        }
        [TestMethod]
        public void TestArabWaterSourceConstruction()
        {
            INations nationType = new ArabBedouin();
            object testObject = nationType.DrawWaterSource(g, pt);
            NullVillageItem NullWaterTest = new NullVillageItem(pt);

            NullWaterTest.Equals(testObject);
        }

        [TestMethod]
        public void TestInuitWaterSourceConstruction()
        {
            INations nationType = new InuitHunters();
            object testObject = nationType.DrawWaterSource(g, pt);
            NullVillageItem NullWaterTest = new NullVillageItem(pt);

            NullWaterTest.Equals(testObject);
        }
        [TestMethod]
        public void TestNullWaterSourceConstruction()
        {
            INations nationType = new NullNation();
            object testObject = nationType.DrawWaterSource(g, pt);
            NullVillageItem NullWaterTest = new NullVillageItem(pt);

            //Assert.AreEqual(s, BDHouseTest);
            NullWaterTest.Equals(testObject);
        }
    }
}
