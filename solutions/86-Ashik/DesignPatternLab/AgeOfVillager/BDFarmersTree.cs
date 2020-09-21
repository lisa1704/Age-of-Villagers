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
            width = 16;
            height = 18;
            startAngle = 0;
            sweepAngle = 360;
            g.DrawArc(myPen, x, y, width, height, startAngle, sweepAngle);

            g.DrawLine(myPen, x + 6, y + 10, x + 9, y + 10);
            g.DrawLine(myPen, x + 6, y + 10, x + 6, y + 23);
            g.DrawLine(myPen, x + 9, y + 10, x + 9, y + 23);
            g.DrawLine(myPen, x + 6, y + 23, x + 9, y + 23);
        }
    }
}
