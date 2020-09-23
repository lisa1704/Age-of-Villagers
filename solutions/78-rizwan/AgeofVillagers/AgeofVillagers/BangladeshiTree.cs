using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class BangladeshiTree : Itree
    {
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public BangladeshiTree(Graphics g)
        {
            this.g = g;
        }
        public void createTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(p, x - 25, y - 25, 50, 50, 0, 360);
            g.DrawLine(p, x - 1, y, x + 1, y);
            g.DrawLine(p, x + 1, y, x + 1, y + 50);
            g.DrawLine(p, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(p, x - 1, y + 50, x - 1, y);
        }
    }
}
