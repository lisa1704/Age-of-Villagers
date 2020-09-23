using System;
using System.Drawing;
using System.Windows.Forms;
using Xunit;

namespace AgeofVillagers.Test
{
    public class UnitTest1
    {
        public System.Windows.Forms.Panel panel1;
        [Fact]
        public void BangladeshiTerrainTest()
        {
            Graphics g = panel1.CreateGraphics();
            BangladeshiFarmers bf = new BangladeshiFarmers(g);
            Color actual = bf.terrain(panel1);
            Color expected = Color.Green;
            actual.Equals(expected);
        }
        [Fact]
        public void ArabTerrainTest()
        {
            Graphics g = panel1.CreateGraphics();
            ArabBeduoin ab = new ArabBeduoin(g);
            Color actual = ab.terrain(panel1);
            Color expected = Color.LightYellow;
            actual.Equals(expected);
        }
        [Fact]
        public void EgyptianTerrainTest()
        {
            Graphics g = panel1.CreateGraphics();
            EgyptianKing ek = new EgyptianKing(g);
            Color actual = ek.terrain(panel1);
            Color expected = Color.Yellow;
            actual.Equals(expected);
        }
        [Fact]
        public void InuitTerrainTest()
        {
            Graphics g = panel1.CreateGraphics();
            InuitHunters inuit = new InuitHunters(g);
            Color actual = inuit.terrain(panel1);
            Color expected = Color.White;
            actual.Equals(expected);
        }
    }
}
