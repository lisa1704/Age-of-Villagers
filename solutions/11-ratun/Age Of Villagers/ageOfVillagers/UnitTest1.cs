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
            Assert.AreEqual("Drawing Inuit House", menuform.testShape("Inuit Hunters","house",0,0));
        }
    }
}