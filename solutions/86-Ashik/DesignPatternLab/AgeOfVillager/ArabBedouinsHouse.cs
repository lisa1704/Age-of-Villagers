using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class ArabBedouinsHouse : IHouse
    {
        int x, y;
        private readonly Graphics g;
        Pen myPen = new Pen(Color.Black);
        public ArabBedouinsHouse(Graphics graphics)
        {
            this.g = graphics;
        }

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x - 24, y + 24);
            g.DrawLine(myPen, x, y, x + 24, y + 24);
            g.DrawLine(myPen, x - 24, y + 24, x + 24, y + 24);
            g.DrawLine(myPen, x, y, x + 20, y - 12);
            g.DrawLine(myPen, x + 20, y - 12, x + 42, y + 12);
            g.DrawLine(myPen, x + 24, y + 24, x + 42, y + 12);
        }
    }
}
