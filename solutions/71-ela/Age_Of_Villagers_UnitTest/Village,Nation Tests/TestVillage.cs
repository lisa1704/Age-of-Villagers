using System;
using System.Collections.Generic;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Age_Of_Villagers_UnitTest.Village_Nation_Tests
{
    [TestClass]
    public class TestVillage
    {
        Village village;
        public List<Point> testHousePosition, testWaterSoucePosition;
        public List<Point> testTreePosition;
        public  TestVillage()
        {
            village = new Village();
            testHousePosition = new List<Point>();
            testTreePosition = new List<Point>();
            testWaterSoucePosition = new List<Point>();
        }
        [TestMethod]
        public void VillageNameTest()
        {
            village.VillageName = "Kathakali";
            Assert.AreEqual("Kathakali", village.villageName);

        }
        [TestMethod]
        public void TestItemPosition()
        {
            Point house1 = new Point(1,2);
            Point house2 = new Point(2, 3);
            Point tree1 = new Point(1, 2);
            Point tree2 = new Point(2, 3);
            Point waterSource1 = new Point(1, 2);
            Point waterSource2= new Point(2, 3);


            testHousePosition.Add(house1);
            testHousePosition.Add(house2);
            testTreePosition.Add(tree1);
            testTreePosition.Add(tree2);
            testWaterSoucePosition.Add(waterSource1);
            testWaterSoucePosition.Add(waterSource2);


            village.housePosition.Add(house1);
            village.housePosition.Add(house2);
            village.treePosition.Add(tree1);
            village.treePosition.Add(tree2);
            village.waterSoucePosition.Add(waterSource1);
            village.waterSoucePosition.Add(waterSource2);


            CollectionAssert.AreEqual(testHousePosition, village.housePosition);
            CollectionAssert.AreEqual(testTreePosition, village.treePosition);
            CollectionAssert.AreEqual(testWaterSoucePosition, village.waterSoucePosition);





        }
    }
}
