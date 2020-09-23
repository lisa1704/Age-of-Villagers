using System;
using System.Collections.Generic;
using System.Text;
using empty_project;
using Xunit;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Drawing;

namespace AgeofVillegersTest
{
    public class InuitHuntersVillage
    {
        [Fact]
        public void InuitVillageTest()
        {
            AbstractNation inuitVillageHouse = new InuitHunters(new Panel());
            Assert.AreEqual(inuitVillageHouse.getHouseType().GetType(), new InuitHuntersHouse().GetType());

            AbstractNation inuitVillageTree = new InuitHunters(new Panel());
            Assert.AreEqual(inuitVillageTree.getTreeType().GetType(), new InuitHuntersTree().GetType());

            AbstractNation inuitVillageWaterSource = new InuitHunters(new Panel());
            Assert.AreEqual(inuitVillageWaterSource.getWaterSourceType().GetType(), new InuitHuntersWaterSource().GetType());
        }
    }
}
