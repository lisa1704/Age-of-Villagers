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
        public void BDFarmersTerrainColorTest()
        {
            var bdFarmersColor = new BangladeshiFarmers(g, form);
            Color color = bdFarmersColor.setColor();
            Assert.AreEqual(Color.FromArgb(70, 209, 0), color);
        }
        [Test]
        public void ArabBedouinsTerrainColorTest()
        {
            var arabBedouinsColor = new ArabBedouin(g, form);
            Color color = arabBedouinsColor.setColor();
            Assert.AreEqual(Color.FromArgb(210, 213, 24), color);
        }
        [Test]
        public void EgyptianKingsTerrainColorTest()
        {
            var egyptianKingsColor = new EgyptianKings(g, form);
            Color color = egyptianKingsColor.setColor();
            Assert.AreEqual(Color.FromArgb(250, 253, 2), color);
        }
        [Test]
        public void InuitHuntersTerrainColorTest()
        {
            var inuitHuntersColor = new InuitHunters(g, form);
            Color color = inuitHuntersColor.setColor();
            Assert.AreEqual(Color.FromArgb(246, 246, 236), color);
        }
    }
}