using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestNationObjectThroughTerrianColor
    {
        [TestMethod]
        public void TestBangladeshiNationObjectThroughColor()
        {
            NationFactory BDObject = new NationFactory();
            INations Ntype = BDObject.GetNation("BangladeshiFarmers");
            INations l = new BangladeshiFarmers();
            Color s = l.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(s, testobjest);
        }
        [TestMethod]
        public void TestArabBedouinNationObjectThroughColor()
        {
            NationFactory ArabObject = new NationFactory();
            INations Ntype = ArabObject.GetNation("ArabBedouin");
            INations l = new ArabBedouin();
            Color ArabColor = l.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();
            Assert.AreEqual(ArabColor, testobjest);
        }
        [TestMethod]
        public void TestEgyptianKingNationObjectThroughColor()
        {
            NationFactory EgyptianObject = new NationFactory();
            INations Ntype = EgyptianObject.GetNation("EgyptianKings");
            INations Egypt = new EgyptianKings();
            Color EgyptColor = Egypt.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(EgyptColor, testobjest);
        }
        [TestMethod]
        public void TestInuitKingsNationObjectThroughColor()
        {
            NationFactory InuitObject = new NationFactory();
            INations Ntype = InuitObject.GetNation("InuitHunters");
            INations Inuit = new InuitHunters();
            Color InuitColor = Inuit.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(InuitColor, testobjest);
        }      
    }
}
