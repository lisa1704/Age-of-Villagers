using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class NationTest
    {
        Nationfactory nationfactory = new Nationfactory();
        [Fact]
        public void BangladeshinationTest()
        {
            INation actual = nationfactory.GetNation("Bangladeshi");
            INation expected = new Bangladeshi();
            actual.Equals(expected);
        }
    }
}
