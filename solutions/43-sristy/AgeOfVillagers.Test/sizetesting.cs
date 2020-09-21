using Xunit;
using Age_of_villagers;
using System.Drawing;
using Size = Age_of_villagers.Size;

namespace AgeOfVillagers.Test
{
    public class sizetesting
    {
        Size housesize = new Housesize();
        Size treesize = new Treesize();
        Size bdwatersourcesize = new BDWatersourcesize();
        Size egptwatersourcesize = new EGPTWatersourcesize();

        [Fact]
        public void housesizeTest()
        {
            Assert.Equal(16, housesize.GetHeight());
            Assert.Equal(16, housesize.GetWeidth());
        }
        [Fact]
        public void treesizeTest()
        {
            Assert.Equal(24, treesize.GetHeight());
            Assert.Equal(16, treesize.GetWeidth());
        }
        [Fact]
        public void bdwatersourcesizeTest()
        {
            Assert.Equal(16, bdwatersourcesize.GetHeight());
            Assert.Equal(24, bdwatersourcesize.GetWeidth());
        }
        [Fact]
        public void egptwatersourcesizeTest()
        {
            Assert.Equal(12, egptwatersourcesize.GetHeight());
            Assert.Equal(12, egptwatersourcesize.GetWeidth());
        }

    }
}
