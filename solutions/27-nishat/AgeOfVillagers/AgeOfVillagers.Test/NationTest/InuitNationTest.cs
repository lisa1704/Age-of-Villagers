using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class InuitNationTest
    {
        Point point = new Point(100, 100);
        InuitHunters inuithunters = new InuitHunters("Inuit Hunters");

        [Fact]
        public void InuitNationNameTest()
        {
            Assert.Equal("Inuit Hunters", inuithunters.GetNationName());
        }

        [Fact]
        public void InuitTerrainColorTest()
        {
            Assert.Equal(Color.White, inuithunters.GetTerrainColor());
        }

        [Fact]
        public void inuitHouseTest()
        {
            Assert.IsType<IglooHouse>(inuithunters.GetHouse(point));
        }

        [Fact]
        public void InuitTreeTest()
        {
            Assert.IsType<NoTree>(inuithunters.GetTree(point));
        }

        [Fact]
        public void InuitWatersourceTest()
        {
            Assert.IsType<NoWaterResource>(inuithunters.GetWaterResource(point));
        }
    }
}
