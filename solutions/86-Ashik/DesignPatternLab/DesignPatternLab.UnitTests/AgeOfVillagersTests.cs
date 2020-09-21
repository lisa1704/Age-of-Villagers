using AgeOfVillager;
using NUnit.Framework;
using System.Drawing;

namespace DesignPatternLab.UnitTests
{
    public class AgeOfVillagersTests
    {
        private readonly Form1 form;
        Graphics g;

        public AgeOfVillagersTests()
        {
            form = new Form1();
        }

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
        [Test]
        public void ColorTest()
        {
            var bdFarmers = new BangladeshiFarmers(g, form);
            Color color = bdFarmers.setColor();
            Assert.AreEqual(Color.FromArgb(70, 209, 0), color);
        }
    }
}