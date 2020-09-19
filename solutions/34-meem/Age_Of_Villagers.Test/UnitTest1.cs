using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;

namespace Age_Of_Villagers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BangladeshiNation bd = new BangladeshiNation();
            string color = bd.getColor();
            Assert.AreEqual("green", color);


        }
    }
}
