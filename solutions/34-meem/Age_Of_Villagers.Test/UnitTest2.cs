using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Age_Of_Villagers.Test
{
    [TestClass]
    public class TestingItemConstruction
    {
        [TestMethod]
        public void TestbdHouse()
        {
            BangladeshiHouse bd = new BangladeshiHouse();
            string Actual = bd.Testbdhouse();
            string expected = "BDhouse";
            Assert.AreEqual(expected, Actual);

        }

        [TestMethod]
        public void TestEgyptTree()
        {
            EgyptianTree tree = new EgyptianTree();
            string Actual = tree.TestTree();
            string expected = "EgyptTree";
            Assert.AreEqual(expected, Actual);

        }




    }
}
