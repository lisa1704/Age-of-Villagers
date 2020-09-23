using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using age_of_villagers;

namespace age_of_villagers_test
{
    class Inuit_test
    {
        [Fact]
        public void Object()
        {
            INations expected = new Inuit_Hunters();
            village_factory v = new village_factory();
            INation actual = v.get_nation("Inuit Hunters");
            actual.Equals(expected);
        }
        [Fact]
        public void InuitColorTest()
        {
            Inuit_Hunters color = new Inuit_Hunters();
            Color actual = color.draw_terrain();
            Color expected = Color.White;

            actual.Equals(expected);
        }
    }
}
