using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        private string item;

        public ArabBedouin()
        {

        }

        public void DrawHouse(Graphics g, Point point)
        {
            Triangle triangle = new Triangle();
            triangle.DrawShape(g, point);
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Drawing Tree for Arab Bedouin");
        }
        public void DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
        }
    }
}
