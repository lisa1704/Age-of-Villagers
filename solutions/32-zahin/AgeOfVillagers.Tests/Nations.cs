using Xunit;
using System.Drawing;

namespace AgeOfVillagers.Tests
{
    public class Nations
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

        [Fact]
        public void ArabWaterTest()
        {
            Graphics g;
            Point point = new Point(0,0);
            ArabBedouin arab = new ArabBedouin();
            string expected = arab.DrawWaterSource(null, point);
            Village v = new Village();
            string actual = v.GetVillage("Arab Bedouin").DrawWaterSource(null, point);
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
