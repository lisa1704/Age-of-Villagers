using Xunit;

namespace AgeOfVillagers.Test
{
    public class NationFactoryTest
    {
        [Fact]
        public void BangladeshiNationFactoryTest()
        {
            BangladeshiNationfactory bangladeshinationfactory = new BangladeshiNationfactory();

            Assert.Equal("Bangladeshi Farmers", bangladeshinationfactory.NationName);
            Assert.IsType<BangladeshiFarmers>(bangladeshinationfactory.GetNation());
        }
    }
}
