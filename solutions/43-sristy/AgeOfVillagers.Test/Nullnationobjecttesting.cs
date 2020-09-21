using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Nullnationobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        Point lptop = new Point(200, 100);
        [Fact]
        public void nullhouseTest()
        {
            IObject actual = nationfactory.GetNation("").Draw_house(lptop);
            IObject expected = null_obj.Instance;
            actual.Equals(expected);
        }
        [Fact]
        public void nulltreeTest()
        {
            IObject actual = nationfactory.GetNation("").Draw_tree(lptop);
            IObject expected = null_obj.Instance;
            actual.Equals(expected);
        }
        [Fact]
        public void nullwatersourceTest()
        {
            IObject actual = nationfactory.GetNation("").Draw_watersource(lptop);
            IObject expected = null_obj.Instance;
            actual.Equals(expected);
        }

    }
}
