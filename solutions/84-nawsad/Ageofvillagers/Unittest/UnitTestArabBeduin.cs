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
        void ArabBeduinHouse()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Arab Beduin");
            testnation = factory.get_Nation();
            String Actual = testnation.drawHouse(50, 50);
            String Expected = "Arab House Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void ArabBeduinTree()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Arab Beduin");
            testnation = factory.get_Nation();
            String Actual = testnation.drawTree(50, 50);
            String Expected = "Arab Tree Drawn";
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        void ArabWaterSource()
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation testnation;
            INationFactory factory = new INationFactory(g, p, "Arab Beduin");
            testnation = factory.get_Nation();
            String Actual = testnation.drawWaterSource(50, 50);
            String Expected = "No water Source for Arab Beduin";
            Assert.Equal(Expected, Actual);
        }
    }
}
