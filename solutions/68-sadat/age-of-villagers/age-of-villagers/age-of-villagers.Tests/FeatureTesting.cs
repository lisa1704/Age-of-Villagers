using age_of_villagers.age_of_village.Items.Tree;
using age_of_villagers.age_of_village.Items.WaterSource;
using age_of_villagers.age_of_villagers.Nations;
using age_of_villagers.age_of_villagrs.Nations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace age_of_villagers.age_of_villagers.Tests
{
    public class FeatureTesting
    {
        
        [Fact]
        public void InuitTreeTest()
        {
            Nation nation = new InuitHunter(new System.Windows.Forms.Panel());

            var expected = typeof(NullTree);
            var actual = nation.tree;

            Assert.IsType(expected, actual);
        }
        [Fact]
        public void InuitWaterSourceTest()
        {
            Nation nation = new InuitHunter(new System.Windows.Forms.Panel());

            var expected = typeof(NullWaterSource);
            var actual = nation.waterSource;

            Assert.IsType(expected, actual);
        }
        [Fact]
        public void ArabBedoinWaterSourceTest()
        {
            Nation nation = new ArabBedouin(new System.Windows.Forms.Panel());

            var expected = typeof(NullWaterSource);
            var actual = nation.waterSource;

            Assert.IsType(expected, actual);
        }
        [Fact]
        public void ArabBedoinWaterBackgroundColorTest()
        {
            Nation nation = new ArabBedouin(new System.Windows.Forms.Panel());

            var expected = typeof(System.Drawing.Color);
            var actual = nation.color;

            Assert.IsType(expected, actual);
        }

    }
}
