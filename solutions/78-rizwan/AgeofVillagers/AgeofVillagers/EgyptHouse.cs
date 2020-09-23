using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class EgyptHouse : Ihouse
    {
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public EgyptHouse(Graphics g)
        {
            this.g = g;
        }
        public void createHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 24, y - 28);
            g.DrawLine(p, x + 24, y - 28, x - 12, y - 64);
            g.DrawLine(p, x - 12, y - 64, x - 40, y - 16);
            g.DrawLine(p, x - 40, y - 16, x, y);
            g.DrawLine(p, x - 12, y - 64, x, y);
        }
    }
}
