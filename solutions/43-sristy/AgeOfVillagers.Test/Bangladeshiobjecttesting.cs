using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Bangladeshiobjecttesting
    {
        [Fact]
        public void BangladeshinationTest()
        {
            Point lptop = new Point(200, 100);
            IObject actual = new Bangladeshi_house(lptop);
            actual.Equals(expected);
        }
    }
}
