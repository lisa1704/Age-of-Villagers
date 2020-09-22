using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class BDFarmersWaterSource : IWaterSource
    {
        int x, y;
        private readonly Graphics g;
        Pen myPen = new Pen(Color.Black);
        public BDFarmersWaterSource(Graphics graphics)
        {
            this.g = graphics;
        }
        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x + 24, y);
            g.DrawLine(myPen, x, y, x, y+16);
            g.DrawLine(myPen, x + 24, y, x + 24, y + 16);
            g.DrawLine(myPen, x, y + 16, x + 24, y + 16);
        }
    }
}
