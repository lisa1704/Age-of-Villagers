using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgeOfvillagerUnitTest
{
    public class NationNameTest
    {
        [Fact]
        public void BdVillageTest()
        {
            string expected = "Bangladeshi Farmers";
            NationFactory nationFactory = new NationFactory();
            INation nation = nationFactory.GetNation("Bangladeshi Farmers");
            string actual = nation.getNationName();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ArabVillageTest()
        {
            string expected = "Arab Beduin";
            NationFactory nationFactory = new NationFactory();
            INation nation = nationFactory.GetNation("Arab Beduin");
            string actual = nation.getNationName();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void EgyptianVillageTest()
        {
            string expected = "Egyptian King";
            NationFactory nationFactory = new NationFactory();
            INation nation = nationFactory.GetNation("Egyptian king");
            string actual = nation.getNationName();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InuitVillageTest()
        {
            string expected = "Inuit Hunter";
            NationFactory nationFactory = new NationFactory();
            INation nation = nationFactory.GetNation("Inuit Hunter");
            string actual = nation.getNationName();
            Assert.Equal(actual, expected);
        }
    }
}
