using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class EgyptNationTest
    {
        Point point = new Point(100, 100);
        EgyptianKings egyptiankings = new EgyptianKings("Egyptian Kings");

        [Fact]
        public void EgyptNationNameTest()
        {
            Assert.Equal("Egyptian Kings", egyptiankings.GetNationName());
        }

        [Fact]
        public void EgyptTerrainColorTest()
        {
            Assert.Equal(Color.Yellow, egyptiankings.GetTerrainColor());
        }

        [Fact]
        public void EgyptHouseTest()
        {
            Assert.IsType<EgyptianHouse>(egyptiankings.GetHouse(point));
        }

        [Fact]
        public void EgyptTreeTest()
        {
            Assert.IsType<EgyptianTree>(egyptiankings.GetTree(point));
        }

        [Fact]
        public void EgyptWatersourceTest()
        {
            Assert.IsType<EgyptianWell>(egyptiankings.GetWaterResource(point));
        }
    }
}
