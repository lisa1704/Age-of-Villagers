using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class BDFarmersTree : ITree
    {
        int x, y;
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
            Rectangle rect1 = new Rectangle(x,y,30,40);
            Rectangle rect2 = new Rectangle(x+12, y+25, 5, 40);
            g.DrawEllipse(myPen, rect1);
            g.DrawRectangle(myPen, rect2);
        }
    }
}
