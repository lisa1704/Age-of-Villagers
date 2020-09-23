using System;
using Xunit;
using Age_of_Villagers.BangladeshiFarmers;
using System.Drawing;
using Age_of_Villagers.EgyptianKings;
using Age_of_Villagers.ArabBedouin;
using Age_of_Villagers.Age_of_Villagers;

namespace AOV_Test
{
    public class UnitTest1
    {
        Graphics g;
        Point p = new Point(40, 40);
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void BangladeshiBackground()
        {
            BangladeshiFarmers back = new BangladeshiFarmers();
            Color b1 = back.BackgroundColor();
            Color b2 = Color.Green;
            Assert.Equal(b1, b2);
        }

        [Fact]
        public void EgyptianBackground()
        {
            EgyptianKings back = new EgyptianKings();
            Color b1 = back.BackgroundColor();
            Color b2 = Color.Yellow;
            Assert.Equal(b1, b2);
        }

        [Fact]
        public void ArabBackground()
        {
            ArabBedouin back = new ArabBedouin();
            Color b1 = back.BackgroundColor();
            Color b2 = Color.GreenYellow;
            Assert.Equal(b1, b2);
        }

        [Fact]
        public void BangladeshiHouse()
        {
            IShape bdhouse = new BangladeshiFarmers().testhouse(p);
            IShape house = new BangladeshiFarmers().DrawHouse(g,p);
            bdhouse.Equals(house);

        }

        [Fact]
        public void BangladeshiTree()
        {
            IShape bdtree = new BangladeshiFarmers().testtree(p);
            IShape tree = new BangladeshiFarmers().DrawTree(g, p);
            bdtree.Equals(tree);

        }

        [Fact]
        public void BangladeshiWater()
        {
            IShape bdwater = new BangladeshiFarmers().testwater(p);
            IShape water = new BangladeshiFarmers().DrawWaterSource(g, p);
            bdwater.Equals(water);

        }

        [Fact]
        public void ArabHouse()
        {
            IShape arabhouse = new ArabBedouin().testhouse(p);
            IShape house = new ArabBedouin().DrawHouse(g, p);
            arabhouse.Equals(house);

        }

        [Fact]
        public void ArabTree()
        {
            IShape arabtree = new ArabBedouin().testtree(p);
            IShape tree = new ArabBedouin().DrawTree(g, p);
            arabtree.Equals(tree);

        }

        [Fact]
        public void ArabWater()
        {
            IShape arabwater = new ArabBedouin().testwater(p);
            IShape water = new ArabBedouin().DrawWaterSource(g, p);
            arabwater.Equals(water);

        }

        [Fact]
        public void EgyptianHouse()
        {
            IShape egypthouse = new EgyptianKings().testhouse(p);
            IShape house = new EgyptianKings().DrawHouse(g, p);
            egypthouse.Equals(house);

        }

    }
}
