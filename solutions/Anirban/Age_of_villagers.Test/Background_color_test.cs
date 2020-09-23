using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Xunit;
using AgeOfVillagers.Nations;

namespace Age_of_villagers.Test
{
    public class Background_color_test
    {

        [Fact]
        public void BDcolor()
        {
            INations nations = new Bangladeshi_farmers();
            Color actual = nations.terrain_Color();
            Color expected = Color.Green;
            Assert.Equal(expected, actual);
        }
    }
}
