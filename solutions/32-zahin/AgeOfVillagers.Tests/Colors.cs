using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;

namespace AgeOfVillagers.Tests
{
    public class Colors
    {
        [Fact]
        public void BangladeshiColorTest()
        {
            BangladeshiFarmers color = new BangladeshiFarmers();
            Color actual = color.DrawTerrain();
            Color expected = Color.PaleGreen;

            actual.Equals(expected);
        }

        [Fact]
        public void ArabColorTest()
        {
            ArabBedouin color = new ArabBedouin();
            Color actual = color.DrawTerrain();
            Color expected = Color.LightGoldenrodYellow;

            actual.Equals(expected);
        }

        [Fact]
        public void EgyptColorTest()
        {
            EgyptianKing color = new EgyptianKing();
            Color actual = color.DrawTerrain();
            Color expected = Color.Gold;

            actual.Equals(expected);
        }

        [Fact]
        public void InuitColorTest()
        {
            InuitHunters color = new InuitHunters();
            Color actual = color.DrawTerrain();
            Color expected = Color.White;

            actual.Equals(expected);
        }
    }
}
