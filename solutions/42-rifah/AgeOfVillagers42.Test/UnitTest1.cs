using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgeOfVillagers;
using AgeOfVillagers.Bangladeshi_Farmers;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BangladeshiFarmers bdfarmerTest = new BangladeshiFarmers();
            string bdTest = bdfarmerTest.BangladeshiFarmerTest();
            Assert.AreEqual("Bangladesh", bdTest);
        }
    }
}
