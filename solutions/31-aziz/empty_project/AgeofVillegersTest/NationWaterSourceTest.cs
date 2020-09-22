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
        }
    }
}
