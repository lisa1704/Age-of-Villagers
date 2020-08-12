using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers.Tests
{
    [TestClass()]
    public class TestVillage
    {
       

        [TestMethod()]

        public void ItemPositionTest()
        {
            Village testVillage = new Village() { housePosition = {new Point(1,2),new Point(3,4),new Point(4,5) } };
                
 
            List<Point> expectedHousePosition =new List<Point>() ;
            expectedHousePosition.Add(new Point(1,2));
            expectedHousePosition.Add(new Point(3, 4));
            expectedHousePosition.Add(new Point(4, 5));

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expectedHousePosition[i].x, testVillage.housePosition[i].x);
                Assert.AreEqual(expectedHousePosition[i].y, testVillage.housePosition[i].y);

            }



        }

        [TestMethod()]
        public void VillageNameTest()
        {
            Village testVillage = new Village() { villageName ="Kathakali"};


            String expectedVillageName = "Kathakali";
          

            
            Assert.AreEqual(expectedVillageName,testVillage.villageName);
               

            



        }
    }
}