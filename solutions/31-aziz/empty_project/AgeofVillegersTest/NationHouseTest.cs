using System;
using System.Collections.Generic;
using System.Text;
using empty_project;
using Xunit;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeofVillegersTest
{
    public class NationHouseTest
    {
        [Fact]
        public void HouseTest()
        {
            AbstractNation bangladeshiFarmersHouse = new BangladeshiFarmers(new Panel());
            Assert.AreEqual(bangladeshiFarmersHouse.getHouseType().GetType(), new BangladeshiFarmersHouse().GetType());
        }
    }
}
