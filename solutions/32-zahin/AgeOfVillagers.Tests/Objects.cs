using Xunit;

namespace AgeOfVillagers.Tests
{
    public class Objects
    {
        [Fact]
        public void BangladeshiTest()
        {
            INation expected = new BangladeshiFarmers();
            Village v = new Village();
            INation actual = v.GetVillage("Bangladeshi Farmers");
            //Assert.True(actual.Equals(expected));
            actual.Equals(expected);
        }
        [Fact]
        public void ArabTest()
        {
            ArabBedouin arab = new ArabBedouin();
            INation expected = arab;
            Village v = new Village();
            INation actual = v.GetVillage("Arab Bedouin");
            actual.Equals(expected);
        }
        [Fact]
        public void EgyptianTest()
        {
            EgyptianKing pharaoh = new EgyptianKing();
            INation expected = pharaoh;
            Village v = new Village();
            INation actual = v.GetVillage("Egyptian Kings");
            actual.Equals(expected);
        }
        [Fact]
        public void InuitTest()
        {
            InuitHunters inuit = new InuitHunters();
            INation expected = inuit;
            Village v = new Village();
            INation actual = v.GetVillage("Inuit Hunters");
            actual.Equals(expected);
        }
    }
}
/*
Arab Bedouin
Bangladeshi Farmers
Egyptian Kings
Inuit Hunters
*/
