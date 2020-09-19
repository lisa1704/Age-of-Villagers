using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class ArabNationTest
    {
        INation nation = new Arab();
        village villa, expected;
        Point treepoint = new Point(200, 200);
        Point riverpoint = new Point(300, 300);
        Point housepoint = new Point(400, 400);
        string name = "abc";
        [SetUp]
        public void Setup()
        {
            expected.name = name;
            expected.tree_points = new List<Point>() { treepoint };
            expected.house_points = new List<Point>() { housepoint };
        }
        [Test]
        public void Testname()
        {
            nation.set_villagename(name);
            string village_name = nation.get_villagename();
            village_name.Equals(name);
        }
        [Test]
        public void testbackground()
        {
            Color expected = Color.LightYellow;
            Color c = nation.set_background();
            expected.Equals(c);
        }
        [Test]
        public void testtree()
        {
            IShape tree = nation.draw_tree(treepoint);
            IShape Arabtree = new Artree(treepoint, 30, 20);
            Arabtree.Equals(tree);
        }
        [Test]
        public void testriver()
        {
            IShape river = nation.draw_river(riverpoint);
            IShape Arriver = nullshape.Instance;
            Arriver.Equals(river);
        }
        [Test]
        public void testhouse()
        {
            IShape house = nation.draw_house(housepoint);
            IShape Arhouse = new Arhouse(housepoint, 50, 50);
            Arhouse.Equals(house);
        }

        [Test]
        public void testsaving()
        {
            INation arab = new Arab();
            arab.set_villagename(name);
            arab.draw_house(housepoint);
            arab.draw_tree(treepoint);
            ICommandVillage save = new SaveVillage();
            villa = save.execute("D:\\game1.aov", arab);
            expected.Equals(villa);
        }
        [Test]
        public void testopening()
        {
            INation nation = new Arab();
            ICommandVillage open = new OpenVillage();
            villa = open.execute("D:\\game1.aov", nation);
            expected.Equals(villa);
        }
    }
}