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
    public class BangladeshiFarmersVillage
    {
        [Fact]
        public void BangladeshiVillageTest()
        {
            AbstractNation bangladeshiVillageHouse = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiVillageHouse.getHouseType().GetType(), new BangladeshiFarmersHouse().GetType());

            AbstractNation bangladeshiVillageTree = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiVillageTree.getTreeType().GetType(), new BangladeshiFarmersTree().GetType());

            AbstractNation bangladeshiVillageWaterSource = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiVillageWaterSource.getWaterSourceType().GetType(), new BangladeshiFarmersWaterSource().GetType());
        }
    }
}
