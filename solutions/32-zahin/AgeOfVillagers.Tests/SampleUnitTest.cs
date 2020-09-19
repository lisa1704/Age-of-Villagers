using System;
using Xunit;
using AgeOfVillagers;
using System.Drawing;
using System.Windows.Forms;
namespace AgeOfVillagers.Tests
{
    public class SampleUnitTest
    {
        [Fact]
        public void VillageTypeTest()
        {
            Graphics g = null;
            Point point = null;
            string item = "water";
            string villageType = "Arab Bedouin";
            Village v = new Village();
            string expected = "Bedouin villages do not build their own water source";
            Assert.Equal(expected, v.GetVillage(villageType).DrawWaterSource(g, point));
        }
    }
}
