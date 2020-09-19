using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers.Test
{
    public class InuitNationTest
    {
        INation nation = new Inuit();
        village villa, expected;
        Point treepoint = new Point(200, 200);
        Point riverpoint = new Point(300, 300);
        Point housepoint = new Point(400, 400);
        string name = "abc";
        [SetUp]
        public void Setup()
        {
            expected.name = name;
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
        public void testhouse()
        {
            IShape house = nation.draw_house(housepoint);
            IShape inuithouse = new igloo(housepoint,50,50);
            inuithouse.Equals(house);
        }

        [Test]
        public void testnull()
        {
            IShape ob_river = nation.draw_river(riverpoint);
            IShape ob_tree = nation.draw_tree(treepoint);
            IShape null_ob = nullshape.Instance;
            ob_river.Equals(null_ob);
            ob_tree.Equals(null_ob);
        }
        [Test]
        public void testsaving()
        {
            INation inuit = new Inuit();
            inuit.set_villagename(name);
            inuit.draw_house(housepoint);
            ICommandVillage save = new SaveVillage();
            villa = save.execute("D:\\game3.aov", inuit);
            expected.Equals(villa);
        }
        [Test]
        public void testopening()
        {
            INation nation = new Inuit();
            ICommandVillage open = new OpenVillage();
            villa = open.execute("D:\\game3.aov", nation);
            expected.Equals(villa);
        }
    }
}