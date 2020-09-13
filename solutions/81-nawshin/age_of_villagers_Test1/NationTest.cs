using Microsoft.VisualStudio.TestTools.UnitTesting;
using age_of_villagers;

namespace age_of_villagers_Test1
{   [TestClass()]
    public class NationTest
    {   [TestMethod()]
        public void Test1()
        {
            NationFactory nation =new NationFactory();
            INation type=nation.CreateNation("Bangladesh");
            string house=type.draw_house();
            string tree = type.draw_tree();
            string water = type.draw_waterSource();

            Assert.AreEqual(house, "Bangladesh house");
            Assert.AreEqual(tree, "Bangladesh tree");
            Assert.AreEqual(water, "Bangladesh watersource");
        }
        [TestMethod()]
        public void Test2()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Arab");
            string house = type.draw_house();
            string tree = type.draw_tree();
            string water = type.draw_waterSource();

            Assert.AreEqual(house, "Arab house");
            Assert.AreEqual(tree, "Arab tree");
            Assert.AreEqual(water, "Arab watersource");
        }
        [TestMethod()]
        public void Test3()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Egypt");
            string house = type.draw_house();
            string tree = type.draw_tree();
            string water = type.draw_waterSource();

            Assert.AreEqual(house, "Egypt house");
            Assert.AreEqual(tree, "Egypt tree");
            Assert.AreEqual(water, "Egypt watersource");
        }
        [TestMethod()]
        public void Test4()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Inuit");
            string house = type.draw_house();
            string tree = type.draw_tree();
            string water = type.draw_waterSource();

            Assert.AreEqual(house, "Inuit house");
            Assert.AreEqual(tree, "Inuit tree");
            Assert.AreEqual(water, "Inuit watersource");
        }
    }
}
//tryout cls = new age_of_villagers.tryout();
//string res = cls.nameId("Nawshin");
//Assert.AreEqual(res, "Nawshin");
