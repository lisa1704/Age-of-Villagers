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
    }
}
