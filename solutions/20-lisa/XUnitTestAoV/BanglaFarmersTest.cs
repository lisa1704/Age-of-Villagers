using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace UnitTestAoV
{
    
    [TestFixture]
    public class BanglaFarmersTest
    {
        INation nation = new BangladeshiFarmers();
        Point tpoint = new Point(30, 30);
        Point hpoint = new Point(40, 40);
        Point wspoint = new Point(50, 50);

        [SetUp]
        public void Setup()
        {

        }
        [TestCase]
        public void BDTerrainColorTest()
        {
            BangladeshiFarmers bdterrainColor = new BangladeshiFarmers();
            Color expected = Color.Green;
            Color actual = bdterrainColor.SetTerrain();
            Assert.AreEqual(expected, actual);

        }
        
    }
}
