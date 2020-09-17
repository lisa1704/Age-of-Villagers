using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class EgyptianKingsHouse : IHouse
    {
        private readonly Graphics g;
        int x, y;
        Pen myPen = new Pen(Color.Black);
        public EgyptianKingsHouse(Graphics graphics)
        {
            this.g = graphics;
        }
        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x + 30, y + 30);
            g.DrawLine(myPen, x, y, x - 30, y + 30);
            g.DrawLine(myPen, x, y, x, y + 40);
            g.DrawLine(myPen, x+30, y+30, x, y + 40);
            g.DrawLine(myPen, x - 30, y + 30, x, y + 40);
        }
    }
}
