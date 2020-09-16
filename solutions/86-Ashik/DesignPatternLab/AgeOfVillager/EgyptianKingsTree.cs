using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class EgyptianKingsTree : ITree
    {
        int x, y;
        private readonly Graphics g;
        public EgyptianKingsTree(Graphics graphics)
        {
            this.g = graphics;
        }
        Pen myPen = new Pen(Color.Black);

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x+30, y-30);
            g.DrawLine(myPen, x, y, x - 30, y - 30);
        }
    }
}
