using NUnit.Framework;

namespace DesignPatternLab.UnitTests
{
    public class AgeOfVillagersTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_Test()
        {
            var ageOfVillagers = new AgeOfVillagers();
            int res = ageOfVillagers.sum(2, 2);
            Assert.AreEqual(4, res);
        }
    }
}