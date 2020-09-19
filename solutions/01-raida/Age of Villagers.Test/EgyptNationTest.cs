using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class EgyptNationTest
    {
        INation nation = new Egypt();
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
            expected.river_points = new List<Point>() { riverpoint };
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
            Color expected = Color.PaleGoldenrod;
            Color c = nation.set_background();
            expected.Equals(c);
        }

        [Test]
        public void testtree()
        {
            IShape tree = nation.draw_tree(treepoint);
            IShape EgyptTree = new Egtree(treepoint, 30, 20);
            EgyptTree.Equals(tree);
        }
        [Test]
        public void testriver()
        {
            IShape river = nation.draw_river(riverpoint);
            IShape EgyptRiver = new circle(riverpoint,20);
            EgyptRiver.Equals(river);
        }
        [Test]
        public void testhouse()
        {
            IShape house = nation.draw_house(housepoint);
            IShape EgyptHouse = new Eghouse(housepoint, 50, 50);
            EgyptHouse.Equals(house);
        }

        [Test]
        public void testsaving()
        {
            INation egypt = new Egypt();
            egypt.set_villagename(name);
            egypt.draw_house(housepoint);
            egypt.draw_river(riverpoint);
            egypt.draw_tree(treepoint);
            ICommandVillage save = new SaveVillage();
            villa = save.execute("D:\\game2.aov", egypt);
            expected.Equals(villa);
        }
        [Test]
        public void testopening()
        {
            INation nation = new Egypt();
            ICommandVillage open = new OpenVillage();
            villa = open.execute("D:\\game2.aov", nation);
            expected.Equals(villa);
        }

    }
}