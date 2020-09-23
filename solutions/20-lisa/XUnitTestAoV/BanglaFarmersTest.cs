using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;
using AgeOfVillagers;
using Xunit;

namespace UnitTestAoV
{
    public class BanglaFarmersTest
    {

        INation na = new BangladeshiFarmers();
        Point tpoint = new Point(30, 30);
        Point hpoint = new Point(40, 40);
        Point wspoint = new Point(50, 50);
        [Fact]
        public void BDTerrainColorTest()
        {
            BangladeshiFarmers bdterrainColor = new BangladeshiFarmers();
            Color expected = Color.Green;
            Color actual = bdterrainColor.SetTerrain();
            Assert.Equal(expected, actual);

        }
        Graphics g;
        Point point = new Point(30, 30);
        [Fact]
        public void BDTreeTest()
        {
            //BangladeshiFarmers bdtreetest = new BangladeshiFarmers();
            //Object expected = new BanglaTree(point);
            //Object actual = bdtreetest.DrawTree(g,point);
            //Assert.AreEqual(expected, actual);
            //Assert.IsInstanceOf<BanglaTree>(na.GetNation(new Point(30, 30)).DrawTree();
           
        }
        
    }
}
