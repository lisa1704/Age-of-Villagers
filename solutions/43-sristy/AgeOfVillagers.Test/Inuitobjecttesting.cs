﻿using Xunit;
using Age_of_villagers;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Inuitobjecttesting
    {
        Nationfactory nationfactory = new Nationfactory();
        Point lptop = new Point(200, 100);
        [Fact]
        public void InuithouseTest()
        {
            IObject actual = nationfactory.GetNation("Inuit").Draw_house(lptop);
            IObject expected = new Inuit_house(lptop);
            actual.Equals(expected);
        }
        [Fact]
        public void InuittreeTest()
        {
            IObject actual = nationfactory.GetNation("Inuit").Draw_tree(lptop);
            IObject expected = new null_obj();
            actual.Equals(expected);
        }
        [Fact]
        public void InuitwatersourceTest()
        {
            IObject actual = nationfactory.GetNation("Inuit").Draw_watersource(lptop);
            IObject expected = new null_obj();
            actual.Equals(expected);
        }
    }
}