using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;

namespace Age_of_villagers.Test
{
    public class Colortest
    {
        

        [Fact]
        public void ArabColorTets()
        {
            ArabBedouin arab = new ArabBedouin();
            Color expected = Color.LightYellow;
            Color actual = arab.DrawBackground();
            Assert.Equal(expected, actual);


        }







    }
}
