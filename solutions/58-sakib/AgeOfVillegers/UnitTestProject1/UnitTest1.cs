using AgeOfVillegers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ForTest forTest = new ForTest();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(forTest.sum(5,6), 11);
        }
    }
}
