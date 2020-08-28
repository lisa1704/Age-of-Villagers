using System;
using System.Collections.Generic;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Age_Of_Villagers_UnitTest.Village_Nation_Tests
{
    [TestClass]
    public class TestNation
    {
        List<Nation> nationList = new List<Nation> { new BangladeshiFarmers(), new ArabBeduin(), new EgyptianKings(), new InuitHunters() };


        [TestMethod()]
        public void TreeSizeTest()
        {

            ItemSize treeSize = new ItemSize(16, 24);
            foreach (Nation n in nationList)
            {
                Assert.AreEqual(treeSize.width, n.treeSize.width);
                Assert.AreEqual(treeSize.height, n.treeSize.height);

            }

        }

        [TestMethod()]
        public void HouseSizeTest()
        {

            ItemSize houseSize = new ItemSize(16, 16);
            foreach (Nation n in nationList)
            {
                Assert.AreEqual(houseSize.width, n.houseSize.width);
                Assert.AreEqual(houseSize.height, n.houseSize.height);

            }

        }

    }
}
