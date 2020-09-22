using System;
using System.Collections.Generic;
using System.Text;
using empty_project;
using Xunit;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeofVillegersTest
{
    public class EgyptianKingsVillage
    {
        [Fact]
        public void EgyptianVillageTest()
        {
            AbstractNation egyptianVillageHouse = new EgyptianKings(new Panel());
            Assert.AreEqual(egyptianVillageHouse.getHouseType().GetType(), new EgyptianKingsHouse().GetType());

            AbstractNation egyptianVillageTree = new EgyptianKings(new Panel());
            Assert.AreEqual(egyptianVillageTree.getTreeType().GetType(), new EgyptianKingsTree().GetType());

            AbstractNation egyptianVillageWaterSource = new EgyptianKings(new Panel());
            Assert.AreEqual(egyptianVillageWaterSource.getWaterSourceType().GetType(), new EgyptianKingsWaterSource().GetType());
        }
    }
}
