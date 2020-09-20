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

        public void createTree()
        {
               
        }

        public void createWaterSource()
        {
            
        }
    }
}
