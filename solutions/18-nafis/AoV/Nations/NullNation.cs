using System;
using AoV.Shapes;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    public class NullNation : INation
    {
        public Color TerrainColor()
        {
            return Color.Empty;
        }

        public string getName()
        {
            return "NullNation";
        }
        public void DrawHouse(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw");
        }

        public void DrawTree(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw");
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw");
        }
    }

}
