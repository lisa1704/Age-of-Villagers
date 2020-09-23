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
    public partial class Ageofvillagers : Form
    {
        [Fact]
        void InuitHunterHouse()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Inuit Hunters");
            testnation = factory.get_Nation();
            String Actual = testnation.drawHouse(50, 50);
            String Expected = "Inuit Hunter House Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void InuitHunterTree()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Inuit Hunters");
            testnation = factory.get_Nation();
            String Actual = testnation.drawTree(50, 50);
            String Expected = "No Tree for inuit hunters";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void InuitHunterWaterSource()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Inuit Hunters");
            testnation = factory.get_Nation();
            String Actual = testnation.drawWaterSource(50, 50);
            String Expected = "No water source for inuit Hunters";
            Assert.Equal(Expected, Actual);
        }
    }
}
