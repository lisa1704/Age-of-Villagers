using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ageOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MenuForm m = new MenuForm;
            Assert.AreEqual("", m.GetVillageName());
        }
    }
}
