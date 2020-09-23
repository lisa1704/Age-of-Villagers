using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class ArabHouse:Ihouse
    {
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        public ArabHouse(Graphics g)
        {
            this.g = g;
        }
        public void createHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x + 25, y - 25, x + 50, y - 30);
            g.DrawLine(p, x + 50, y - 30, x + 70, y - 15);
            g.DrawLine(p, x + 50, y, x + 70, y - 15);
            g.DrawLine(p, x, y, x + 25, y - 25);
            g.DrawLine(p, x + 25, y - 25, x + 50, y);
            g.DrawLine(p, x, y, x + 50, y);
        }
    }
}
