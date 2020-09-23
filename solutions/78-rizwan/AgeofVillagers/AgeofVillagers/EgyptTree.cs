using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class EgyptTree : Itree
    {
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public EgyptTree(Graphics g)
        {
            this.g = g;
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
    }
}
