using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfvillagerUnitTest
{
    public class NationBackgroundTest
    {
        [Fact]
        public void BdBackGroundTest()
        {
            Color expected = Color.Green;
            INation nation = new BangladeshiFarmer();
            Color actual = nation.GetColor();
            actual.Equals(expected);
        }

        [Fact]
        public void arabBackGroundTest()
        {
            Color expected = Color.Orange;
            INation nation = new ArabBeduin();
            Color actual = nation.GetColor();
            actual.Equals(expected);
        }

        [Fact]
        public void egyptianBackGroundTest()
        {
            Color expected = Color.Yellow;
            INation nation = new BangladeshiFarmer();
            Color actual = nation.GetColor();
            actual.Equals(expected);
        }

        [Fact]
        public void inuitBackGroundTest()
        {
            Color expected = Color.White;
            INation nation = new BangladeshiFarmer();
            Color actual = nation.GetColor();
            actual.Equals(expected);
        }



    }
}
