using System;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgeOfVillagers;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Drawing;

namespace AgeOfVillagers_Test
{
    [TestClass]
    public class NationTest
    {

        [TestMethod]
        public void TestNationHouse()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsHouse = new EgyptianKings(newg , panel);
            Assert.AreEqual(egyptianKingsHouse.getHouseType(), new EgyptianKingsHouse().GetType());
            NationAbstract bangladeshiFarmersHouse = new BangladeshiFarmers(newg, panel);
            Assert.AreEqual(bangladeshiFarmersHouse.getHouseType(), new BangladeshiFarmersHouse().GetType());
            NationAbstract arabBedouinHouse = new ArabBedouin(newg, panel);
            Assert.AreEqual(arabBedouinHouse.getHouseType(), new ArabBedouinHouse().GetType());
            NationAbstract inuitHuntersHouse = new InuitHunters(newg, panel);
            Assert.AreEqual(inuitHuntersHouse.getHouseType(), new InuitHuntersHouse().GetType());

        }

        [TestMethod]
        public void TestNationTree()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsTree = new EgyptianKings(newg, panel);
            Assert.AreEqual(egyptianKingsTree.getHouseType(), new EgyptianKingsTree().GetType());
            NationAbstract bangladeshiFarmerTree = new BangladeshiFarmers(newg, panel);
            Assert.AreEqual(bangladeshiFarmerTree.getHouseType(), new BangladeshiFarmersTree().GetType());
            NationAbstract arabBedouinTree = new ArabBedouin(newg, panel);
            Assert.AreEqual(arabBedouinTree.getHouseType(), new ArabBedouinTree().GetType());
            NationAbstract inuitHuntersTree = new InuitHunters(newg, panel);
            Assert.AreEqual(inuitHuntersTree.getHouseType(), new NullTree().GetType());

        }

        [TestMethod]
        public void TestNationWaterResource()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsWS = new EgyptianKings(newg, panel);
            Assert.AreEqual(egyptianKingsWS.getHouseType(), new EgyptianKingsWaterSource().GetType());
            NationAbstract bangladeshiFarmerWS = new BangladeshiFarmers(newg, panel);
            Assert.AreEqual(bangladeshiFarmerWS.getHouseType(), new BangladeshiFarmersWaterSource().GetType());
            NationAbstract arabBedouinWS = new ArabBedouin(newg, panel);
            Assert.AreEqual(arabBedouinWS.getHouseType(), new NullWaterSource().GetType());
            NationAbstract inuitHuntersTree = new InuitHunters(newg, panel);
            Assert.AreEqual(inuitHuntersTree.getHouseType(), new NullWaterSource().GetType());

        }

    }
}
