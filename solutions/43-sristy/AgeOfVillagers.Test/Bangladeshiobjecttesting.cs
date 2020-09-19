using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Bangladeshiobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        [Fact]
        public void BangladeshinationTest()
        {
            Point lptop = new Point(200, 100);
            IObject actual = nationfactory.GetNation("Bangladeshi").Draw_house(lptop);
            IObject expected = new Bangladeshi_house(lptop);
            actual.Equals(expected);
        }
    }
}
