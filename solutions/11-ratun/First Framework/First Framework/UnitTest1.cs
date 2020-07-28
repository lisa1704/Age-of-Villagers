using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First_Framework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actualValue = 10;
            var expectedValue = 10;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
