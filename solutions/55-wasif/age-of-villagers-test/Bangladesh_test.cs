using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using age_of_villagers;

namespace age_of_villagers_test
{
    class Bangladesh_test
    {
        [Fact]
        public void Object()
        {
            INations expected = new Bangladeshi_Farmers();
            village_factory v = new village_factory();
            INations actual = v.get_nation("Bangladeshi Farmers");
            actual.Equals(expected);
        }
        [Fact]
        public void ColorTest()
        {
            Bangladeshi_Farmers color = new Bangladeshi_Farmers();
            Color actual = color.draw_terrain();
            Color expected = Color.PaleGreen;

            actual.Equals(expected);
        }
    }
}
