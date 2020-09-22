using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class EgyptianKing : Ination
    {
        Pen p = new Pen(Color.Red, 3);
        Graphics g;
        int x, y;
        public EgyptianKing(Graphics g)
        {
            this.g = g;
        }

        public void createHouse(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(p, x, y, x + 24, y - 28);
            g.DrawLine(p, x + 24, y - 28, x - 12, y - 64);
            g.DrawLine(p, x - 12, y - 64, x - 40, y - 16);
            g.DrawLine(p, x - 40, y - 16, x, y);
            g.DrawLine(p, x - 12, y - 64, x, y);
        }

        public void createTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 12, y - 48);
            g.DrawLine(p, x, y, x - 8, y - 48);
            g.DrawLine(p, x + 12, y - 48, x + 32, y - 96);
            g.DrawLine(p, x + 12, y - 48, x + 20, y - 96);
            g.DrawLine(p, x + 12, y - 48, x + 8, y - 96);
            g.DrawLine(p, x - 8, y - 48, x - 32, y - 96);
            g.DrawLine(p, x - 8, y - 48, x - 16, y - 96);
            g.DrawLine(p, x - 8, y - 48, x - 4, y - 96);
        }

        public void createWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(p, x - 20, y - 20, 40, 40, 0, 360);
        }
        public void terrain(Panel p)
        {
            p.BackColor = Color.Yellow;
        }
    }
}
