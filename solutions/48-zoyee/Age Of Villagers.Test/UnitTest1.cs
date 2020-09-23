using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Age_Of_Villagers;
using System.Drawing;

namespace Age_Of_Villagers.Test
{
    public class UnitTest1
    {
        [Fact]
        [TestMethod]
        public void TestMethod1()
        {
            Bangladeshi_Farmers bdfarmerTest = new Bangladeshi_Farmers();
            string s = bdfarmerTest.Bd_FarmerTest();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Bangladeshi", s);
        }
        [TestMethod]
        public void BDfarmersColorTest()
        {
            Bangladeshi_Farmers BDFcolor = new Bangladeshi_Farmers();
            Color getColor1 = BDFcolor.BackGroundColor();
            Color matchColor1 = Color.Green;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(getColor1, matchColor1);
        }
    }
}
