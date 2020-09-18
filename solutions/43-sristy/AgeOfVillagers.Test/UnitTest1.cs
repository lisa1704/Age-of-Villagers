using Xunit;
using Age_of_villagers;
using System.Drawing;


namespace AgeOfVillagers.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int var = 2;
            var expectedValue = 2;
            Assert.Equal(expectedValue, var);
        }

        [Fact]
        public void Test2()
        {
            INation nation = new Bangladeshi();
            Color expected = Color.LightGreen;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected,actual);
        }

    }

}
