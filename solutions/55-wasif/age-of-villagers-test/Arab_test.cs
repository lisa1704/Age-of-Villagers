using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using age_of_villagers;

namespace age_of_villagers_test
{
    class Arab_test
    {
        
        [Fact]
        public void Object()
        {
            INations expected = new Arab_Beduin();
            village_factory v = new village_factory();
            INations actual = v.get_nation("Arab Beduin");
            actual.Equals(expected);
        }


        [Fact]
        public void Color()
        {
            ArabBeduin color = new ArabBeduin();
            Color actual = color.draw_terrain();
            Color expected = Color.Goldenrod;

            actual.Equals(expected);
        }

    }
}