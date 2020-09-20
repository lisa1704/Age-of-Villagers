using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTest1
    {       
        [TestMethod]
        public void TestBangladeshiNationObject()
        {
            NationFactory BDObject = new NationFactory();
            INations Ntype= BDObject.GetNation("BangladeshiFarmers");
            BangladeshiFarmers l = new BangladeshiFarmers();
            Color s = l.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();
           
            Assert.AreEqual(s, testobjest);
        }
        [TestMethod]
        public void TestArabBedouinNationObject()
        {
            NationFactory ArabObject = new NationFactory();
            INations Ntype = ArabObject.GetNation("ArabBedouin");
            ArabBedouin l = new ArabBedouin();
            Color ArabColor = l.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(ArabColor, testobjest);
        }

        [TestMethod]
        public void TestEgyptianKingNationObject()
        {
            NationFactory EgyptianObject = new NationFactory();
            INations Ntype = EgyptianObject.GetNation("EgyptianKings");
            EgyptianKings Egypt = new EgyptianKings();
            Color EgyptColor = Egypt.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(EgyptColor, testobjest);
        }
        [TestMethod]
        public void TestInuitKingsNationObject()
        {
            NationFactory InuitObject = new NationFactory();
            INations Ntype = InuitObject.GetNation("InuitHunters");
            InuitHunters Inuit = new InuitHunters();
            Color InuitColor = Inuit.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(InuitColor, testobjest);
        }
        [TestMethod]
        public void TestNullNationObject()
        {
            NationFactory NullObject = new NationFactory();
            INations Ntype = NullObject.GetNation("");
            NullNation nullNation = new NullNation();
            Color NullColor = nullNation.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();

            Assert.AreEqual(NullColor, testobjest);
        }
      
    }
}
