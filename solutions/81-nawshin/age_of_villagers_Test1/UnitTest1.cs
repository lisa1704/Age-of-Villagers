using Microsoft.VisualStudio.TestTools.UnitTesting;
using age_of_villagers;

namespace age_of_villagers_Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            tryout cls = new age_of_villagers.tryout();
            string res = cls.nameId("Nawshin");
            Assert.AreEqual(res, "Nawshin");

        } 
    }
}
