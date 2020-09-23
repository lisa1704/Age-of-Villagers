using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class EgyptWater : Iwatersource
    {
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public EgyptWater(Graphics g)
        {
            this.g = g;
        }
        public void createWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(p, x - 20, y - 20, 40, 40, 0, 360);
        }
    }
}
