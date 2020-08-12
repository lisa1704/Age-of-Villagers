using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_Of_Villagers.Tests
{
    [TestClass()]
    public class TestNation
    {
        List<Nation> nationList = new List<Nation> { new BangladeshiFarmers(), new ArabBeduin(), new EgyptianKings(), new InuitHunters() };
        
        
        [TestMethod()]
        public void TreeSizeTest()
        {
           
            ItemSize treeSize = new ItemSize(16, 24);
            foreach(Nation n in nationList)
            {
                Assert.AreEqual(treeSize.width, n.treeSize.width);
                Assert.AreEqual(treeSize.height, n.treeSize.height);

            }
             
        }

        [TestMethod()]
        public void HouseSizeTest()
        {

            ItemSize houseSize = new ItemSize(16, 16);
            foreach (Nation n in nationList)
            {
                Assert.AreEqual(houseSize.width, n.houseSize.width);
                Assert.AreEqual(houseSize.height, n.houseSize.height);

            }

        }


    }
}