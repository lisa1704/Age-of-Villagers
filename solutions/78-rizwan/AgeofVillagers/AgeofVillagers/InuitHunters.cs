using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeofVillagers
{

    class InuitHunters : Ination
    {
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        int x, y;
        public InuitHunters(Graphics g)
        {
            this.g = g;
        }

        public void createHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawArc(p, x - 25, y - 25, 50, 50, 0, -180);
            g.DrawArc(p, x - 50, y - 50, 100, 100, 0, -180);
            g.DrawLine(p, x - 50, y, x + 50, y);
        }

        public void createTree(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void createWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
