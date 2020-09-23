using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class ArabTree : Itree
    {
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        public ArabTree(Graphics g)
        {
            this.g = g;
        }
        public void createTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 40, y - 10);
            g.DrawLine(p, x, y, x - 40, y - 10);
            g.DrawLine(p, x, y, x + 20, y - 30);
            g.DrawLine(p, x, y, x - 20, y - 30);
            g.DrawLine(p, x, y, x, y - 30);
            g.DrawLine(p, x - 1, y, x + 1, y);
            g.DrawLine(p, x + 1, y, x + 1, y + 50);
            g.DrawLine(p, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(p, x - 1, y + 50, x - 1, y);
        }
    }
}
