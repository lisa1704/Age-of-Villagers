using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class ArabNationTest
    {
        Point point = new Point(100, 100);
        ArabBedouin arabbedouin = new ArabBedouin("Arab Bedouin");

        [Fact]
        public void ArabNationNameTest()
        {
            Assert.Equal("Arab Bedouin", arabbedouin.GetNationName());
        }

        [Fact]
        public void ArabTerrainColorTest()
        {
            Assert.Equal(Color.Gold, arabbedouin.GetTerrainColor());
        }

        [Fact]
        public void ArabHouseTest()
        {
            Assert.IsType<ArabHouse>(arabbedouin.GetHouse(point));
        }

        [Fact]
        public void ArabTreeTest()
        {
            Assert.IsType<ArabTree>(arabbedouin.GetTree(point));
        }

        [Fact]
        public void ArabWatersourceTest()
        {
            Assert.IsType<NoWaterResource>(arabbedouin.GetWaterResource(point));
        }
    }
}
