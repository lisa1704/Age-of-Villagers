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
    }
}
