using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class BDFarmersTree : ITree
    {
        int x, y, width, height, startAngle, sweepAngle;
        private readonly Graphics g;
        Pen myPen = new Pen(Color.Black);
        public BDFarmersTree(Graphics graphics)
        {
            this.g = graphics;
        }
        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            width = 24;
            height = 42;
            startAngle = 0;
            sweepAngle = 360;
            g.DrawArc(myPen, x, y, width, height, startAngle, sweepAngle);
            g.DrawLine(myPen, x+10, y+24, x + 14, y + 24);
            g.DrawLine(myPen, x + 10, y + 24, x + 10, y + 64);
            g.DrawLine(myPen, x + 10, y + 64, x + 14, y + 64);
            g.DrawLine(myPen, x + 14, y + 24, x + 14, y + 64);
        }
    }
}
