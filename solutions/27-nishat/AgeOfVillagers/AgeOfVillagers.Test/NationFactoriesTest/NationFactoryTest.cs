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

            bangladeshinationfactory.NationName = "new nation";
            Assert.Equal("new nation", bangladeshinationfactory.NationName);
        }

        [Fact]
        public void ArabNationFactoryTest()
        {
            ArabBedouinNationfactory arabnationfactory = new ArabBedouinNationfactory();

            Assert.Equal("Arab Bedouin", arabnationfactory.NationName);
            Assert.IsType<ArabBedouin>(arabnationfactory.GetNation());

            arabnationfactory.NationName = "new nation";
            Assert.Equal("new nation", arabnationfactory.NationName);
        }

        [Fact]
        public void EgyptNationFactoryTest()
        {
            EgyptianKingsNationfactory egyptnationfactory = new EgyptianKingsNationfactory();

            Assert.Equal("Egyptian Kings", egyptnationfactory.NationName);
            Assert.IsType<EgyptianKings>(egyptnationfactory.GetNation());

            egyptnationfactory.NationName = "new nation";
            Assert.Equal("new nation", egyptnationfactory.NationName);
        }

        [Fact]
        public void InuitNationFactoryTest()
        {
            InuitHuntersNationfactory inuitnationfactory = new InuitHuntersNationfactory();

            Assert.Equal("Inuit Hunters", inuitnationfactory.NationName);
            Assert.IsType<InuitHunters>(inuitnationfactory.GetNation());

            inuitnationfactory.NationName = "new nation";
            Assert.Equal("new nation", inuitnationfactory.NationName);
        }
    }
}
