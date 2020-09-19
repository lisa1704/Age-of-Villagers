using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class NationPropertyTest
    {
        INation nation= new Bangladesh();
        village villa,expected;
        Point p = new Point(200, 200);
        [SetUp]
        public void Setup()
        {
            expected.name = "abc";
            expected.tree_points =new List<Point>() {p};
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
            IShape tree = nation.draw_tree(p);
            IShape bdtree = new Bdtree(p, 30, 30);
            bdtree.Equals(tree);
        }
        [Test]
        public void testsaving()
        {

            nation.set_villagename("abc");
            nation.draw_house(new Point(200, 200));
            ICommandVillage save = new SaveVillage();
            villa=save.execute("D:\\game.aov", nation);
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