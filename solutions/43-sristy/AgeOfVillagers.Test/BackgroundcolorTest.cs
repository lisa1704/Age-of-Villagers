using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class BackgroundcolorTest
    {
        [Fact]
        public void Bangladeshibackgroundcolor()
        {
            INation nation = new Bangladeshi();
            Color expected = Color.LightGreen;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Egyptianbackgroundcolor()
        {
            INation nation = new Egyptian();
            Color expected = Color.LightYellow;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Arabianbackgroundcolor()
        {
            INation nation = new Arab();
            Color expected = Color.PaleGoldenrod;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Inuitianbackgroundcolor()
        {
            INation nation = new Inuit();
            Color expected = Color.Snow;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Nonationbackgroundcolor()
        {
            INation nation = new NullNation();
            Color expected = Color.White;
            Color actual = nation.get_backcolor();
            Assert.Equal(expected, actual);
        }

    }
}
