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

            //16*16px
            g.DrawLine(myPen, x, y, x + 16, y);
            g.DrawLine(myPen, x, y, x + 8, y - 16);
            g.DrawLine(myPen, x + 16, y, x + 8, y - 16);

            g.DrawLine(myPen, x + 8, y - 16, x + 16, y - 24);
            g.DrawLine(myPen, x + 16, y, x + 24, y - 8);
            g.DrawLine(myPen, x + 16, y - 24, x + 24, y - 8);
        }
    }
}
