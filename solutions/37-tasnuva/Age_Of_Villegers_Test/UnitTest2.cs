﻿using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class NationTest
    {
        Factory_Nation nationfactory = new Factory_Nation();
        [Fact]
        public void BangladeshinationTest()
        {
            INation actual = nationfactory.GetNation("Bangladeshi");
            INation expected = new Bangladeshi();
            actual.Equals(expected);
        }
        [Fact]
        public void EgyptnationTest()
        {
            INation actual = nationfactory.GetNation("Egyptian");
            INation expected = new Egyptian();
            actual.Equals(expected);
        }
        [Fact]
        public void ArabnationTest()
        {
            INation actual = nationfactory.GetNation("Arab");
            INation expected = new Arab();
            actual.Equals(expected);
        }
        [Fact]
        public void InuitnationTest()
        {
            INation actual = nationfactory.GetNation("Inuit");
            INation expected = new Inuit();
            actual.Equals(expected);
        }
        [Fact]
        public void NullnationTest()
        {
            INation actual = nationfactory.GetNation("America");
            INation expected = new NullNation();
            actual.Equals(expected);
        }

    }
}