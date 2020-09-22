
using AgeOfVillagers.Nation;
using AgeOfVillagers.Factories;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class NationFactoryTest
    {
        [Fact]
        public void ExampleTest()
        {
            Assert.Equal(2, 2);
        }

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
    }
}
