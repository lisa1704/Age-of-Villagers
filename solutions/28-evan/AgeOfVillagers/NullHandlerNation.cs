using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NullHandlerNation : INation
    {
        public void DrawHouse(Graphics g,Point p)
        {
            MessageBox.Show("Error Drawing House!");
        }

        public Color DrawTerrain()
        {
            MessageBox.Show("Error Drawing Terrain!");
            return Color.Empty;
        }

        public void DrawTree(Graphics g, Point p)
        {
            MessageBox.Show("Error Drawing Tree!");
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            MessageBox.Show("Error Drawing Water Source!");
        }
    }
}
