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
        void EgyptianHouse()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Egyptian King");
            testnation = factory.get_Nation();
            String Actual = testnation.drawHouse(50, 50);
            String Expected = "Egyptian House Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void EgyptianTree()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Egyptian King");
            testnation = factory.get_Nation();
            String Actual = testnation.drawTree(50, 50);
            String Expected = "Egyptian Tree Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void EgyptianWaterSource()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Egyptian King");
            testnation = factory.get_Nation();
            String Actual = testnation.drawWaterSource(50, 50);
            String Expected = "Egyptian Water Source Drawn";
            Assert.Equal(Expected, Actual);
        }

    }
}
