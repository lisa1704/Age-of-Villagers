using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = 2;
            var expected = 2;
            Assert.AreEqual(actual, expected);
        }
    }
}
