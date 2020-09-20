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
            BangladeshiFarmer expected = new BangladeshiFarmer();
            NationFactory nationFactory = new NationFactory();
            //string villageName = "Bangladeshi Farmers";
            INation actual = nationFactory.GetNation("Bangladeshi Farmers");
            actual.Equals(expected);
        }
    }
}
