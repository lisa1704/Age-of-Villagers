using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows;
namespace WindowsFormsApp1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var actual = 2;
            var expected = 2;
            Assert.AreEqual(actual, expected);

        }
    }
}

