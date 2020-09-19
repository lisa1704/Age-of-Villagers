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

        [Fact]
        public void ArabNationFactoryTest()
        {
            ArabBedouinNationfactory arabnationfactory = new ArabBedouinNationfactory();

            Assert.Equal("Arab Bedouin", arabnationfactory.NationName);
            Assert.IsType<ArabBedouin>(arabnationfactory.GetNation());
        }

        [Fact]
        public void EgyptNationFactoryTest()
        {
            EgyptianKingsNationfactory egyptnationfactory = new EgyptianKingsNationfactory();

            Assert.Equal("Egyptian Kings", egyptnationfactory.NationName);
            Assert.IsType<EgyptianKings>(egyptnationfactory.GetNation());
        }

        [Fact]
        public void InuitNationFactoryTest()
        {
            InuitHuntersNationfactory inuitnationfactory = new InuitHuntersNationfactory();

            Assert.Equal("Inuit Hunters", inuitnationfactory.NationName);
            Assert.IsType<InuitHunters>(inuitnationfactory.GetNation());
        }
    }
}
