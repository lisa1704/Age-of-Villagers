using NUnit.Framework;

namespace AgeOfVillagers.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int expected = 2;
            int actual = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}