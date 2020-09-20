using System;
using Xunit;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfvillagerUnitTest
{
    public class NationTest
    {
        [Fact]
        public void BdVillageTest()
        {
            INation expected = new BangladeshiFarmer();
            NationFactory nationFactory = new NationFactory();
            //string villageName = "Bangladeshi Farmers";
            INation actual = nationFactory.GetNation("Bangladeshi Farmers");
            actual.Equals(expected);
        }

        [Fact]
        public void ArabVillageTest()
        {
            INation expected = new ArabBeduin();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Arab Beduin");
            actual.Equals(expected);
        }

        [Fact]
        public void EgyptianVillageTest()
        {
            INation expected = new EgyptianKing();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Egyptian king");
            actual.Equals(expected);
        }

        [Fact]
        public void InuitVillageTest()
        {
            INation expected = new InuitHunter();
            NationFactory nationFactory = new NationFactory();
            INation actual = nationFactory.GetNation("Inuit Hunter");
            actual.Equals(expected);
        }


    }
}
