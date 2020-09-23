using AgeOfVillagers.Factories;
using AgeOfVillagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class EgyptianKingsTest
    {
        INation bd = new NationFactory("Egyptian Kings").getNation();

        [Fact]
        public void NationNameTest()
        {
            var expected = "Egyptian Kings";
            Assert.Equal(expected, bd.getNationName());
        }
    }
}
