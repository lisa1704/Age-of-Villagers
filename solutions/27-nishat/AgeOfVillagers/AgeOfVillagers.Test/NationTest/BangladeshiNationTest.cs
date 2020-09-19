using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class BangladeshiNationTest
    {

        BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers("Bangladeshi Farmers");

        [Fact]
        public void BangladeshiNationNameTest()
        {
            Assert.Equal("Bangladeshi Farmers", bangladeshiFarmers.GetNationName());
        }

        [Fact]
        public void BangladeshiTerrainColorTest()
        {
            Assert.Equal(Color.Green, bangladeshiFarmers.GetTerrainColor());
        }
    }
}
