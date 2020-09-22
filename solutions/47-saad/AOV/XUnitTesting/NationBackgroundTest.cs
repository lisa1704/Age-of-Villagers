using AOV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace XUnitTesting
{
    public class NationBackgroundTest
    {      
        [Fact]
        public void BdBackgroundTest()
        {
            Color expected = Color.Green;
            INation nation = new BangladeshiNation();
            Color actual = nation.GetColor();
            Assert.Equal(actual,expected);
        }

        [Fact]
        public void ArabBackGroundTest()
        {
            Color expected = Color.FromArgb(240, 230, 140);
            INation nation = new ArabNation();
            Color actual = nation.GetColor();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void EgyptBackGroundTest()
        {
            Color expected = Color.Yellow;
            INation nation = new EgyptianNation();
            Color actual = nation.GetColor();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void inuitBackGroundTest()
        {
            Color expected = Color.White;
            INation nation = new InuitNation();
            Color actual = nation.GetColor();
            Assert.Equal(actual, expected);
        }
    }
}
