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
            Color testbojest = type.GetTerrainColor();
           
            Assert.AreEqual(s, testbojest);
        }
    }
}
