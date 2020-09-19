using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Bangladeshiobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        Point lptop = new Point(200, 100);
        [Fact]
        public void BangladeshihouseTest()
        {
            IObject actual = nationfactory.GetNation("Bangladeshi").Draw_house(lptop);
            IObject expected = new Bangladeshi_house(lptop);
            actual.Equals(expected);
        }
        [Fact]
        public void BangladeshitreeTest()
        {
            IObject actual = nationfactory.GetNation("Bangladeshi").Draw_tree(lptop);
            IObject expected = new Bangladeshi_tree(lptop);
            actual.Equals(expected);
        }
        [Fact]
        public void BangladeshiwatersourceTest()
        {
            IObject actual = nationfactory.GetNation("Bangladeshi").Draw_watersource(lptop);
            IObject expected = new Bangladeshi_watersource(lptop);
            actual.Equals(expected);
        }
    }
}
