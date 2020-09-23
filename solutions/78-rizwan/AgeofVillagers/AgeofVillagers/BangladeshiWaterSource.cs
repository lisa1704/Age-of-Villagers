using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class BangladeshiWaterSource:Iwatersource
    {
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public BangladeshiWaterSource(Graphics g)
        {
            this.g = g;
        }
        public void createWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 20, y + 16);
            g.DrawLine(p, x + 20, y + 16, x + 40, y - 24);
            g.DrawLine(p, x + 40, y - 24, x + 8, y - 40);
            g.DrawLine(p, x + 8, y - 40, x - 16, y - 24);
            g.DrawLine(p, x - 16, y - 24, x - 24, y - 36);
            g.DrawLine(p, x - 24, y - 36, x - 36, y - 28);
            g.DrawLine(p, x - 36, y - 28, x - 36, y);
            g.DrawLine(p, x - 36, y, x - 24, y + 20);
            g.DrawLine(p, x - 23, y + 20, x, y);
        }
    }
}
