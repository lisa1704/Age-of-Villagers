using AgeOfVillager;
using NUnit.Framework;
using System.Drawing;
using System.Windows.Forms;

namespace DesignPatternLab.UnitTests
{
    public class AgeOfVillagersTests
    {
        private readonly Form1 form;
        Graphics g;
        MouseEventArgs e;

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

        //testing object types of trees
        [Test]
        public void BDFarmersTreeTest()
        {
            var bdFarmers = new BangladeshiFarmers(g, form);
            ITree tree = bdFarmers.drawTree(e);
            Assert.IsInstanceOf(typeof(BDFarmersTree), tree);
        }
        [Test]
        public void ArabBedouinsTreeTest()
        {
            var ab = new ArabBedouin(g, form);
            ITree tree = ab.drawTree(e);
            Assert.IsInstanceOf(typeof(ArabBedouinsTree), tree);
        }
        [Test]
        public void EgyptianKingsTreeTest()
        {
            var ab = new EgyptianKings(g, form);
            ITree tree = ab.drawTree(e);
            Assert.IsInstanceOf(typeof(EgyptianKingsTree), tree);
        }

        //testing object types of houses
        [Test]
        public void BDFarmersHouseTest()
        {
            var bdFarmers = new BangladeshiFarmers(g, form);
            IHouse tree = bdFarmers.drawHouse(e);
            Assert.IsInstanceOf(typeof(BDFarmersHouse), tree);
        }
        [Test]
        public void ArabBedouinsHouseTest()
        {
            var ab = new ArabBedouin(g, form);
            IHouse tree = ab.drawHouse(e);
            Assert.IsInstanceOf(typeof(ArabBedouinsHouse), tree);
        }
        [Test]
        public void EgyptianKingsHouseTest()
        {
            var ab = new EgyptianKings(g, form);
            IHouse tree = ab.drawHouse(e);
            Assert.IsInstanceOf(typeof(EgyptianKingsHouse), tree);
        }
        [Test]
        public void InuitHuntersHouseTest()
        {
            var ab = new InuitHunters(g, form);
            IHouse tree = ab.drawHouse(e);
            Assert.IsInstanceOf(typeof(InuitHuntersHouse), tree);
        }

        //testing object types of water source
        [Test]
        public void BDFarmersWaterSourceTest()
        {
            var bdFarmers = new BangladeshiFarmers(g, form);
            IWaterSource tree = bdFarmers.drawWaterSource(e);
            Assert.IsInstanceOf(typeof(BDFarmersWaterSource), tree);
        }
        [Test]
        public void ArabBedouinsWaterSourceTest()
        {
            var ab = new ArabBedouin(g, form);
            IWaterSource tree = ab.drawWaterSource(e);
            Assert.IsInstanceOf(typeof(NullWaterSource), tree);
        }
        [Test]
        public void EgyptianKingsWaterSourceTest()
        {
            var ab = new EgyptianKings(g, form);
            IWaterSource tree = ab.drawWaterSource(e);
            Assert.IsInstanceOf(typeof(EgyptianKingsWaterSource), tree);
        }
        [Test]
        public void InuitHuntersWaterSourceTest()
        {
            var ab = new InuitHunters(g, form);
            IWaterSource tree = ab.drawWaterSource(e);
            Assert.IsInstanceOf(typeof(NullWaterSource), tree);
        }
    }
}