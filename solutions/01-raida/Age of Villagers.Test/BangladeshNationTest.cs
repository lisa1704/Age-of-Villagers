using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class BangladeshNationTest
    {
        INation nation= new Bangladesh();
        village villa,expected;
        Point treepoint = new Point(200, 200);
        Point riverpoint=new Point(300,300);
        Point housepoint = new Point(400, 400);
        [SetUp]
        public void Setup()
        {
            expected.name = "abc";
            expected.tree_points =new List<Point>() { treepoint };
            expected.river_points = new List<Point>() { riverpoint };
            expected.house_points = new List<Point>() { housepoint };
        }
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
            IShape tree = nation.draw_tree(treepoint);
            IShape bdtree = new Bdtree(treepoint, 30, 20);
            bdtree.Equals(tree);
        }
        [Test]
        public void testriver()
        {
            IShape river = nation.draw_river(riverpoint);
            IShape bdriver = new Bdriver(riverpoint);
            bdriver.Equals(river);
        }
        [Test]
        public void testhouse()
        {
            IShape house = nation.draw_house(housepoint);
            IShape bdhouse = new Bdhouse(housepoint, 50,50);
            bdhouse.Equals(house);
        }

        [Test]
        public void testsaving()
        {
            INation Bd = new Bangladesh();
            Bd.draw_house(housepoint);
            Bd.draw_river(riverpoint);
            Bd.draw_tree(treepoint);
            ICommandVillage save = new SaveVillage();
            villa=save.execute("D:\\game.aov", Bd);
            expected.Equals(villa);
        }
        [Test]
        public void testopening()
        {
            INation nation = new Bangladesh();
            ICommandVillage open = new OpenVillage();
            villa = open.execute("D:\\game.aov", nation);
            expected.Equals(villa);
        }
    }
}