using NUnit.Framework;

namespace TestingAoV
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TestCase]
        public void Add()
        {
            DemoClass demoClass = new DemoClass();
            Assert.AreEqual(31, demoClass.Add(20, 11));
        }
        [TestCase]
        public void Sub()
        {
            DemoClass demoClass = new DemoClass();
            Assert.AreEqual(5, demoClass.Sub(10, 5));
        }
    }
}