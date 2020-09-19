using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgeOfVillagers90;
using System.Drawing;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BangladeshiFarmers bdfarmerTest = new BangladeshiFarmers();
            string s = bdfarmerTest.BangladeshiFarmerTest();
            Assert.AreEqual("Bangladeshi", s);
        }
        [TestMethod]
        public void ArabBeduoinColorTest()
        {
            ArabBedouin ABcolor = new ArabBedouin();
            Color colorGet1 = ABcolor.BackGroundColor();
            Color colorMatch1 = Color.YellowGreen;
            Assert.AreEqual(colorGet1, colorMatch1);
        }

        [TestMethod]
        public void BDfarmersColorTest()
        {
            BangladeshiFarmers BDFcolor = new BangladeshiFarmers();
            Color colorGet2 = BDFcolor.BackGroundColor();
            Color colorMatch2 = Color.ForestGreen;
            Assert.AreEqual(colorGet2, colorMatch2);
        }

        [TestMethod]
        public void EKColorTest()
        {
            EgyptianKings EKcolor = new EgyptianKings();
            Color colorGet2 = EKcolor.BackGroundColor();
            Color colorMatch2 = Color.Yellow;
            Assert.AreEqual(colorGet2, colorMatch2);
        }

    }
}
