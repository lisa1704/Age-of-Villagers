using AgeOfVillagers.VillageItem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Tests
{
    public class Nationwise_ItemShapeTest
    {
        private readonly Point point1 = new Point(1, 2);
        private readonly Point point2 = new Point(2, 2);

        [Fact]
        public void ArabBedouin_getHouseShape_Test()
        {
            INation nation = new ArabBedouin();
            var expected = nation.getItemShape(point1, "House");
            var actual = new ArabHouse().getItemShape(point1);
            actual.Equals(expected);
        }

        [Fact]
        public void ArabBedouin_getTreeShape_Test()
        {
            INation nation = new ArabBedouin();
            var expected = nation.getItemShape(point2, "Tree");
            var actual = new ArabTree().getItemShape(point2);
            actual.Equals(expected);
        }

        [Fact]
        public void ArabBedouin_getWaterSourceShape_Test()
        {
            INation nation = new ArabBedouin();
            var expected = nation.getItemShape(point2, "Water");
            var actual = new NoItem().getItemShape(point2);
            actual.Equals(expected);
        }

        //BangladeshiFarmers 

        [Fact]
        public void BangladeshiFarmers_getHouseShape_Test()
        {
            INation nation = new BangladeshiFarmers();
            var expected = nation.getItemShape(point1, "House");
            var actual = new BangladeshiHouse().getItemShape(point1);
            actual.Equals(expected);
        }

        [Fact]
        public void BangladeshiFarmers_getTreeShape_Test()
        {
            INation nation = new BangladeshiFarmers();
            var expected = nation.getItemShape(point2, "Tree");
            var actual = new BangladeshiTree().getItemShape(point2);
            actual.Equals(expected);
        }

        [Fact]
        public void BangladeshiFarmers_getWaterSourceShape_Test()
        {
            INation nation = new BangladeshiFarmers();
            var expected = nation.getItemShape(point2, "Water");
            var actual = new BangladeshiWaterResource().getItemShape(point2);
            actual.Equals(expected);
        }

    }
}
