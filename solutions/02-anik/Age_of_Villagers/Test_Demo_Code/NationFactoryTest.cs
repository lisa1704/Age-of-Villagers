using AgeOfVillagers.Nation;
using AgeOfVillagers.FactoryClasses;
using Xunit;

namespace AgeOfVillagers
{
    public class NationFactoryTest
    {
       

        [Fact]
        public void BangladeshiFarmersTest()
        {
            NationFactory factory = new NationFactory("Bangladeshi Farmers");
            var expected = typeof(BangladeshiFarmers);
            Assert.IsType(expected, factory.getNation());
        }

        [Fact]
        public void EgyptianKingsTest()
        {
            var expected = typeof(EgyptianKings);
            Assert.IsType(expected, new NationFactory("Egyptian Kings").getNation());
        }

        [Fact]
        public void ArabBedouinTest()
        {
            var expected = typeof(ArabBeduin);
            Assert.IsType(expected, new NationFactory("Arab Bedouin").getNation());
        }
        [Fact]
        public void InuitHuntersTest()
        {
            var expected = typeof(InuitHunters);
            Assert.IsType(expected, new NationFactory("Inuit Hunters").getNation());
        }

    }

    
}

