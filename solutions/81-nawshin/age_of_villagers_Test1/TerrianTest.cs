using Microsoft.VisualStudio.TestTools.UnitTesting;
using age_of_villagers;
using System.Drawing;

namespace age_of_villagers_Test1
{
    [TestClass()]
    public class TerrianTest
    {
        [TestMethod()]
        public void test1()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Arab");
            Color color = type.BackColor();
            Assert.AreEqual(color,Color.Yellow);
        }
        [TestMethod()]
        public void test2()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Bangladesh");
            Color color = type.BackColor();
            Assert.AreEqual(color, Color.LightGreen);
        }
        [TestMethod()]
        public void test3()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Egypt");
            Color color = type.BackColor();
            Assert.AreEqual(color, Color.GreenYellow);
        }
        [TestMethod()]
        public void test4()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Inuit");
            Color color = type.BackColor();
            Assert.AreEqual(color, Color.Snow);
        }
    }
}
