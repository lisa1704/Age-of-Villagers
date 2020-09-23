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
        Pen pen;
        Point point = new Point(50, 30);
        NationFactory naF = new NationFactory();
        [Fact]
        public void BDNationNameTest()
        {
            INation expected = naF.GetNation("Bangladeshi Farmers");
            Assert.IsType<BangladeshiFarmers>(expected);
        }
        
    }
}
