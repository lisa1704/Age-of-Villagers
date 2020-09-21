using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Arabianobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        Point lptop = new Point(200, 100);
        [Fact]
        public void ArabhouseTest()
        {
            IObject actual = nationfactory.GetNation("Arab").Draw_house(lptop);
            IObject expected = new Arab_house(lptop,16,16);
            actual.Equals(expected);
        }
        [Fact]
        public void ArabtreeTest()
        {
            IObject actual = nationfactory.GetNation("Arab").Draw_tree(lptop);
            IObject expected = new Arab_tree(lptop,24,16);
            actual.Equals(expected);
        }
        [Fact]
        public void ArabtwatersourceTest()
        {
            IObject actual = nationfactory.GetNation("Arab").Draw_watersource(lptop);
            IObject expected = null_obj.Instance;
            actual.Equals(expected);
        }
    }
}
