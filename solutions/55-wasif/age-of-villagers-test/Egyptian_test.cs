using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using age_of_villagers;

namespace age_of_villagers_test
{
    class Egyptian_test
    {
        [Fact]
        public void Object()
        {
            INations expected = new Egyptian_King();
            village_factory v = new village_factory();
            INations actual = v.get_nation("Egyptian King");
            actual.Equals(expected);
        }
        [Fact]
        public void Color()
        {
            Egyptian_King color = new Egyptian_King();
            Color actual = color.draw_terrain();
            Color expected = Color.Yellow;

            actual.Equals(expected);
        }
    }
}
