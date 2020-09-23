using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class InuitHuntersHouse : IHouse
    {
        int x, y;
        private readonly Graphics g;
        Pen myPen = new Pen(Color.Black);
        public InuitHuntersHouse(Graphics graphics)
        {
            this.g = graphics;
        }

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x + 16, y);
            Rectangle rect1 = new Rectangle(x, y-8, 16, 16);
            Rectangle rect2 = new Rectangle(x + 4, y - 4, 8, 8);
            g.DrawArc(myPen, rect1, 0,-180);
            g.DrawArc(myPen, rect2, 0, -180);
        }
    }
}
