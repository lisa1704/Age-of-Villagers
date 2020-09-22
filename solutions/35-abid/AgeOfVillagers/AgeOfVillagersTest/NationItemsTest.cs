using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillagersTest
{
    [TestClass]
    public class NationItemsTest
    {
        [TestMethod]
        public void TestNationHouse()
        {
            INation BDNation = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(BDNation.getHouseType().GetType(), new BangladeshiHouse().GetType());

            INation ArabNation = new ArabBedouins(new Panel());
            Assert.AreEqual(ArabNation.getHouseType().GetType(), new ArabHouse().GetType());

            INation EgyptNation = new EgyptianKings(new Panel());
            Assert.AreEqual(EgyptNation.getHouseType().GetType(), new EgyptianHouse().GetType());

            INation InuitNation = new InuitHunters(new Panel());
            Assert.AreEqual(InuitNation.getHouseType().GetType(), new InuitHouse().GetType());
        }
        [TestMethod]
        public void TestNationTree()
        {
            INation BDNation = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(BDNation.getTreeType().GetType(), new BangladeshiTree().GetType());

            INation ArabNation = new ArabBedouins(new Panel());
            Assert.AreEqual(ArabNation.getTreeType().GetType(), new ArabTree().GetType());

            INation EgyptNation = new EgyptianKings(new Panel());
            Assert.AreEqual(EgyptNation.getTreeType().GetType(), new EgyptianTree().GetType());

            INation InuitNation = new InuitHunters(new Panel());
            Assert.AreEqual(InuitNation.getTreeType().GetType(), new NullTree().GetType());
        }
        [TestMethod]
        public void TestNationWatersrc()
        {
            INation BDNation = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(BDNation.getWatersrcType().GetType(), new BangladeshiWatersrc().GetType());

            INation ArabNation = new ArabBedouins(new Panel());
            Assert.AreEqual(ArabNation.getWatersrcType().GetType(), new NullWatersrc().GetType());

            INation EgyptNation = new EgyptianKings(new Panel());
            Assert.AreEqual(EgyptNation.getWatersrcType().GetType(), new EgyptianWatersrc().GetType());

            INation InuitNation = new InuitHunters(new Panel());
            Assert.AreEqual(InuitNation.getWatersrcType().GetType(), new NullWatersrc().GetType());
        }
    }
}
