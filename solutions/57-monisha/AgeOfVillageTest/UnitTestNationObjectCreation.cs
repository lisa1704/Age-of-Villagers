using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestNationObjectCreation
    {       
        [TestMethod]
        public void TestBangladeshiNationObject()
        {
            NationFactory BDObject = new NationFactory();
            INations Ntype= BDObject.GetNation("BangladeshiFarmers");
            INations testObject = new BangladeshiFarmers();
            /*Color s = testObject.GetTerrainColor();
            Color testobjest = Ntype.GetTerrainColor();*/
            Ntype.Equals(testObject);
            //Assert.AreEqual(s, testobjest);
        }
        [TestMethod]
        public void TestArabBedouinNationObject()
        {
            NationFactory ArabObject = new NationFactory();
            INations Ntype = ArabObject.GetNation("ArabBedouin");
            INations testObject = new ArabBedouin();

            Ntype.Equals(testObject);
            //Assert.AreEqual(ArabColor, testobjest);
        }

        [TestMethod]
        public void TestEgyptianKingNationObject()
        {
            NationFactory EgyptianObject = new NationFactory();
            INations Ntype = EgyptianObject.GetNation("EgyptianKings");
            //EgyptianKings Egypt = new EgyptianKings();
            INations testObject = new EgyptianKings();

            Ntype.Equals(testObject);
        }
        [TestMethod]
        public void TestInuitKingsNationObject()
        {
            NationFactory InuitObject = new NationFactory();
            INations Ntype = InuitObject.GetNation("InuitHunters");
            //InuitHunters Inuit = new InuitHunters();
            INations testObject = new InuitHunters();
            Ntype.Equals(testObject);           
        }
        [TestMethod]
        public void TestNullNationObject()
        {
            NationFactory NullObject = new NationFactory();
            INations Ntype = NullObject.GetNation("");
            //NullNation nullNation = new NullNation();
           
            INations testObject = new InuitHunters();
            Ntype.Equals(testObject);
        }
      
    }
}
