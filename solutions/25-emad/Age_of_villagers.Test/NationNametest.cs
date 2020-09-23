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
        

    }
}

