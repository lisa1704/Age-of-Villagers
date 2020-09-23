using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
namespace Ageofvillagers
{
    public partial class Ageofvillagers:Form
    {
        [Fact]
        void BangladeshiFarmerHouse()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Bangladeshi Farmer");
            testnation = factory.get_Nation();
            String Actual = testnation.drawHouse(50,50);
            String Expected ="Bangladeshi House Drawn";
            Assert.Equal(Expected,Actual);
        }
        [Fact]
        void BangladeshiFarmerTree()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Bangladeshi Farmer");
            testnation = factory.get_Nation();
            String Actual = testnation.drawTree(50, 50);
            String Expected = "Bangladeshi Tree Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void BangladeshiFarmerWaterSource()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Bangladeshi Farmer");
            testnation = factory.get_Nation();
            String Actual = testnation.drawWaterSource(50, 50);
            String Expected = "Bangladeshi Water Source Drawn";
            Assert.Equal(Expected, Actual);
        }
      }
}

