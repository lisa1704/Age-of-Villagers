using System;
using System.Collections.Generic;
using System.Text;
using empty_project;
using Xunit;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeofVillegersTest
{
    public class NationWaterSourceTest
    {
        [Fact]
        public void WaterSourceTest()
        {
            AbstractNation bangladeshiFarmersWaterSource = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiFarmersWaterSource.getWaterSourceType().GetType(), new BangladeshiFarmersWaterSource().GetType());

            AbstractNation arabBedouinWaterSource = new ArabBedouin(new Panel());
            Assert.AreEqual(arabBedouinWaterSource.getWaterSourceType().GetType(), new ArabBedouinWaterSource().GetType());

            AbstractNation egyptianKingsWaterSource = new EgyptianKings(new Panel());
            Assert.AreEqual(egyptianKingsWaterSource.getWaterSourceType().GetType(), new EgyptianKingsWaterSource().GetType());

            AbstractNation inuitHuntersWaterSource = new InuitHunters(new Panel());
            Assert.AreEqual(inuitHuntersWaterSource.getWaterSourceType().GetType(), new InuitHuntersWaterSource().GetType());
        }
    }
}
