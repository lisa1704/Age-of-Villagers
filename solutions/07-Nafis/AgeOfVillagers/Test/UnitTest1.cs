using AgeOfVillagers;
using System.Drawing;
using Xunit;


namespace AgeOfVillagersTests
{
    public class UnitTest1
    {
        MainWindow mw = new MainWindow();
        NationBuilder builder = new NationBuilder();
        VillageState villageState = new VillageState();

        [Fact]
        public void Test1()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void BangladeshiColorTest()
        {
            Color expected = Color.Green;
            Color actual = builder.BuildNations("Bangladeshi Farmers").SetColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArabianColorTest()
        {
            Color expected = Color.LightYellow;
            Color actual = builder.BuildNations("Arab Bedouins").SetColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EgyptianColorTest()
        {
            Color expected = Color.Yellow;
            Color actual = builder.BuildNations("Egyptian Kings").SetColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InuitColorTest()
        {
            Color expected = Color.White;
            Color actual = builder.BuildNations("Inuit Hunters").SetColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DefaultColorTest()
        {
            Color expected = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            Color actual = builder.BuildNations(null).SetColor();
            Assert.Equal(expected, actual);
        }

        /*[Fact]
        public void LocationTest()
        {
            mw.SaveState();
            Assert.Equal(0, mw.houseLocations.Count);
            

        }*/

    }
}
