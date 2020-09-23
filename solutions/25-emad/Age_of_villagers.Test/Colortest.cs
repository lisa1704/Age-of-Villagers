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
        public void ArabColorTest()
        {
            ArabBedouin arab = new ArabBedouin();
            Color expected = Color.LightYellow;
            Color actual = arab.DrawBackground();
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void BangladeshiColorTest()
        {
            BangladeshiFarmers bangladesh = new BangladeshiFarmers();
            Color expected = Color.Green;
            Color actual = bangladesh.DrawBackground();
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void EgyptianKingsColorTest()
        {
            EgyptianKings Egypt = new EgyptianKings();
            Color expected = Color.LightYellow;
            Color actual = Egypt.DrawBackground();
            Assert.Equal(expected, actual);


        }


        [Fact]
        public void InuitColorTest()
        {
            Inuit inuit = new Inuit();
            Color expected = Color.White;
            Color actual = inuit.DrawBackground();
            Assert.Equal(expected, actual);


        }



    }
}
