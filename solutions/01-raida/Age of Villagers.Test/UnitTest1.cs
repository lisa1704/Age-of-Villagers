using NUnit.Framework;

namespace Age_of_Villagers.Test
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
            int value1 = 1;
            int value2 = 2;

            var result = value1+value2;

            Assert.AreEqual(3, result);
        }
    }
}