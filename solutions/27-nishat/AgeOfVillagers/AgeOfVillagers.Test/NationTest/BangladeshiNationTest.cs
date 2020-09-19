using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class BangladeshiNationTest
    {
        Point point = new Point(100, 100);
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

        [Fact]
        public void BangladeshiHouseTest()
        {
            Assert.IsType<BangladeshiHouse>(bangladeshiFarmers.GetHouse(point));
        }

        [Fact]
        public void BangladeshiTreeTest()
        {
            Assert.IsType<BangladeshiTree>(bangladeshiFarmers.GetTree(point));
        }
    }
}
