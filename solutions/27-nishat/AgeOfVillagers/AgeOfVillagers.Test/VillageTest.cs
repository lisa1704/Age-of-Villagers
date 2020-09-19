using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class VillageTest
    {
        string villagename = "my village";
        BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers("Bangladeshi Farmers");

        [Fact]
        public void VillageNameTest()
        {
            Village village = new Village(bangladeshiFarmers, villagename);

            Assert.Equal(villagename, village.GetVillageName());
        }

        [Fact]
        public void VillageGetStateTest()
        {
            Village village = new Village(bangladeshiFarmers, villagename);

            Assert.IsType<Villagestate>(village.GetState());
            Assert.Equal(villagename, village.GetState().GetVillageName());
        }

        [Fact]
        public void VillageSetStateTest()
        {
            Villagestate state = new Villagestate("new village name", new List<Point>(), new List<Point>(), new List<Point>());
            Village village = new Village(bangladeshiFarmers, villagename);
            village.SetState(state);
            Assert.Equal("new village name", village.GetVillageName());
        }
    }
}
