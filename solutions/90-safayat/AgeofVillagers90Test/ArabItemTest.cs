using System;
using System.Drawing;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class ArabItemTest
    {
        Point point = new Point(10, 10);
        [TestMethod]
        public void TestABHouse()
        {
            ArabBedouinHOuse abHouseTest = new ArabBedouinHOuse(point);
            ArabBedouin arabBedouin = new ArabBedouin();
            object abHouseTestObj = arabBedouin.testDrawHouse(point);
            abHouseTestObj.Equals(abHouseTest);
        }

        [TestMethod]
        public void TestABTree()
        {
            ArabBedouinTree abTreeTest = new ArabBedouinTree(point);
            ArabBedouin arabBedouin = new ArabBedouin();
            object abTreeTestObj = arabBedouin.testDrawTree(point);
            abTreeTestObj.Equals(abTreeTest);
        }

    }
}
