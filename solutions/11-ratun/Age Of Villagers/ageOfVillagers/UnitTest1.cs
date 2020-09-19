using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ageOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void number4()
        {
            MenuForm m = new MenuForm();
            m.NewVillage_Click();
            m.OpenVillage_Click();
            m.button1_Click();
            m.House_Click();
            m.Water_click();
            m.button2_Click();
            Assert.AreEqual("Creating the village. Opening the village. Adding a tree. Adding a house. Adding new Water Source. Saving the village. ", m.GetDrawingState());
        }
        [TestMethod]
        public void number5()
        {
            SaveVillageState v = new SaveVillageState();
            Assert.AreEqual("Saving the village. ",v.save());
        }
    }
}
