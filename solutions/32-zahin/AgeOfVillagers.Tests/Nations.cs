using Xunit;
namespace AgeOfVillagers.Tests
{
    public class Nations
    {
        [Fact]
        public void BangladeshiTest()
        {
            BangladeshiFarmers bd = new BangladeshiFarmers();
            INation expected = bd;
            Village v = new Village();
            INation actual = v.GetVillage("Bangladeshi Farmers");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ArabTest()
        {
            ArabBedouin arab = new ArabBedouin();
            INation expected = arab;
            Village v = new Village();
            INation actual = v.GetVillage("Arab Bedouin");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void EgyptianTest()
        {
            EgyptianKing pharaoh = new EgyptianKing();
            INation expected = pharaoh;
            Village v = new Village();
            INation actual = v.GetVillage("Egyptian Kings");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InuitTest()
        {
            InuitHunters inuit = new InuitHunters();
            INation expected = inuit;
            Village v = new Village();
            INation actual = v.GetVillage("Inuit Hunters");
            Assert.Equal(expected, actual);
        }
    }
}
/*
Arab Bedouin
Bangladeshi Farmers
Egyptian Kings
Inuit Hunters
*/
