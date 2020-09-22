using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ageOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            MenuForm menuform = new MenuForm();
            Assert.AreEqual(1,1);
        }
    }
}