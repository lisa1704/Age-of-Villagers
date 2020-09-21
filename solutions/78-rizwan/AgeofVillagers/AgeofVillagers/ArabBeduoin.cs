using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AgeofVillagers
{
    class ArabBeduoin : Ination
    {
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        int x, y;
        public ArabBeduoin(Graphics g)
        {
            this.g = g;
        }
        public void createHouse(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(p, x + 25, y - 25, x + 50, y - 30);
            g.DrawLine(p, x + 50, y - 30, x + 70, y - 15);
            g.DrawLine(p, x + 50, y, x + 70, y - 15);
            g.DrawLine(p, x, y, x + 25, y - 25);
            g.DrawLine(p, x + 25, y - 25, x + 50, y);
            g.DrawLine(p, x, y, x + 50, y);
        }

        public void createTree(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
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

        public void createWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
