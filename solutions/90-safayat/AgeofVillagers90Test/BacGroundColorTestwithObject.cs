using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class BacGroundColorTestwithObject
    {
        [TestMethod]
        public void BDfarmersColorTestWithObject()
        {
            NationFactory BDFcolorObject = new NationFactory();
            INation NationType = BDFcolorObject.GetNation("Bangladeshi Farmers");
            BangladeshiFarmers BDF = new BangladeshiFarmers();
            Color color = BDF.BackGroundColor();
            Color colorObject = NationType.BackGroundColor();

            Assert.AreEqual(color, colorObject);
        }

    }
}
