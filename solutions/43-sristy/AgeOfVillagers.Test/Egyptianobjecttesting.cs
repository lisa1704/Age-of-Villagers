using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Egyptianobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        Point lptop = new Point(200, 100);
        [Fact]
        public void EgypthouseTest()
        {
            IObject actual = nationfactory.GetNation("Egyptian").Draw_house(lptop);
            IObject expected = new Egyptian_house(lptop);
            actual.Equals(expected);
        }
        [Fact]
        public void EgypttreeTest()
        {
            IObject actual = nationfactory.GetNation("Egyptian").Draw_tree(lptop);
            IObject expected = new Egyptian_tree(lptop);
            actual.Equals(expected);
        }
        [Fact]
        public void EgyptwatersourceTest()
        {
            IObject actual = nationfactory.GetNation("Egyptian").Draw_watersource(lptop);
            IObject expected = new Egyptian_watersource(lptop);
            actual.Equals(expected);
        }
    }
}
