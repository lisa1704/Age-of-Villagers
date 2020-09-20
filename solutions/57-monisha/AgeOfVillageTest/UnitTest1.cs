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
            INations type= BDObject.GetNation("BangladeshiFarmers");
            BangladeshiFarmers l = new BangladeshiFarmers();
            Color s = l.GetTerrainColor();
            Color testobjest = type.GetTerrainColor();
           
            Assert.AreEqual(s, testobjest);
        }
        [TestMethod]
        public void TestArabBedouinNationObject()
        {
            NationFactory ArabObject = new NationFactory();
            INations type = ArabObject.GetNation("ArabBedouin");
            ArabBedouin l = new ArabBedouin();
            Color ArabColor = l.GetTerrainColor();
            Color testobjest = type.GetTerrainColor();

            Assert.AreEqual(ArabColor, testobjest);
        }
    }
}
