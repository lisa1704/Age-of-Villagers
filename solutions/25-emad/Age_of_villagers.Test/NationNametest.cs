using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Age_of_villagers.Test
{
    public class NationNametest
    {
        ArabBedouin arabName = new ArabBedouin();
        string actual = "Arab Bedouin";

        [Fact]

        public void ArabNameTest()
        {
            Assert.Equal(actual, arabName.getName());
        }



        BangladeshiFarmers banglaName = new BangladeshiFarmers();
        string actual2 = "Bangla Farmers";

        [Fact]

        public void BanglaNameTest()
        {
            Assert.Equal(actual2, banglaName.getName());
        }






        EgyptianKings EgyptName = new EgyptianKings();
        string actual3 = "Egyptian Kings";

        [Fact]

        public void EgyptNameTest()
        {
            Assert.Equal(actual3, EgyptName.getName());
        }



















    }
}

