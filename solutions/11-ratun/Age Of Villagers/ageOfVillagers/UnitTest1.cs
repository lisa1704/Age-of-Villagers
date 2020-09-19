using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ageOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test1()
        {
            MenuForm m = new MenuForm();
            m.NewVillage_Click("a", "b");
            m.OpenVillage_Click("b");
            VillageState village = new VillageState();
            Assert.AreEqual("Giving State of b", village.GetState());
        }
    }
}
