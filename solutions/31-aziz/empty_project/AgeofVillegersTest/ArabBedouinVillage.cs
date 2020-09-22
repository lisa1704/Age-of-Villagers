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
    public class ArabBedouinVillage
    {
        [Fact]
        public void ArabianVillageTest()
        {
            AbstractNation arabianVillageHouse = new ArabBedouin(new Panel());
            Assert.AreEqual(arabianVillageHouse.getHouseType().GetType(), new ArabBedouinHouse().GetType());

            AbstractNation arabianVillageTree = new ArabBedouin(new Panel());
            Assert.AreEqual(arabianVillageTree.getTreeType().GetType(), new ArabBedouinTree().GetType());

            AbstractNation arabianVillageWaterSource = new ArabBedouin(new Panel());
            Assert.AreEqual(arabianVillageWaterSource.getWaterSourceType().GetType(), new ArabBedouinWaterSource().GetType());
        }
    }
}
