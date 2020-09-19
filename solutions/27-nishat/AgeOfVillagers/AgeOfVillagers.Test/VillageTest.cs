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
        public void VillageCreateTest()
        {
            Village village = new Village(bangladeshiFarmers, villagename);

            Assert.IsType<Village>(village);
        }
    }
}
