using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw") ;
        }

        public void DrawTree(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw");
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            MessageBox.Show("Please select a nation to draw");
        }

        public Color GetColor()
        {
            return Color.Empty;
        }
    }
}
