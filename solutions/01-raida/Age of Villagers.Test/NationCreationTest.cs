using NUnit.Framework;
using Age_of_Villagers;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class NationCreationTest
    {
        INation nation;
        INationFactory factory;

        List<string> nationList = new List<string>() { "Bangladeshi Farmers", "Arab Bedouin", "Egyptian Kings", "Inuit Hunters" };
        [SetUp]
        public void Setup()
        {
            factory = new Nationfactory();
        }

        [Test]

        public void TestBDcreate()
        {
            INation nation=factory.GetNation(nationList[0]);
            new Bangladesh().Equals(nation);
        }
        [Test]
        public void TestARABcreate()
        {
            string selected = nationList[1];
            nation = factory.GetNation(selected);
            new Arab().Equals(nation);
        }
        [Test]
        public void TestEGYPTcreate()
        {
            string selected = nationList[2];
            nation = factory.GetNation(selected);
            new Egypt().Equals(nation);
        }
        [Test]
        public void TestINUITcreate()
        {
            string selected = nationList[3];
            nation = factory.GetNation(selected);
            new Inuit().Equals(nation);
        }
    }

    public class NationPropertyTest
    {
        INation nation= new Bangladesh();

        [Test]
        public void Testname()
        {
            string name="abc";
            nation.set_villagename(name);
            string village_name = nation.get_villagename();
            village_name.Equals(name);
        }
        [Test]
        public void testbackground()
        {
            Color expected = Color.LightGreen;
            Color c =nation.set_background();
            expected.Equals(c);
        }
        [Test]
        public void testtree()
        {
            Point p = new Point(200, 200);
            IShape tree= nation.draw_house(p);
            IShape bdtree = new Bdtree(p, 30, 30);
            bdtree.Equals(tree);
        }
    }
}