using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class BangladeshiFarmers : Ination
    {
        public int x, y, w, h;
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }
        public void createHouse(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(p, x, y, x + 50, y);
            g.DrawLine(p, x + 50, y, x + 50, y + 25);
            g.DrawLine(p, x + 50, y + 25, x, y + 25);
            g.DrawLine(p, x, y + 25, x, y);
            g.DrawLine(p, x, y, x + 25, y - 25);
            g.DrawLine(p, x + 25, y - 25, x + 50, y);
        }

        public void createTree(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawArc(p, x - 25, y - 25, 50, 50, 0, 360);
            g.DrawLine(p, x - 1, y, x + 1, y);
            g.DrawLine(p, x + 1, y, x + 1, y + 50);
            g.DrawLine(p, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(p, x - 1, y + 50, x - 1, y);
        }

        public void createWaterSource(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
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
