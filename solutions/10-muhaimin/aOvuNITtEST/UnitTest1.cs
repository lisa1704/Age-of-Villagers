using Age_of_Villagers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Xunit;

namespace aOvuNITtEST
{
    public class UnitTest1
    {
        [Fact]
        public void Village_name_test()
        {
            Village newVillage = new Village();
            newVillage.villageName = "XYZ";
            var expected = newVillage.getName();
            Assert.Equal(expected, "XYZ");


        }
    }
}
