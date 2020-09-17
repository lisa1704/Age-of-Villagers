using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class BDFarmersHouse : IHouse
    {
        int x, y;
        Pen myPen = new Pen(Color.Black);
        private readonly Graphics g;

        public BDFarmersHouse(Graphics graphics)
        {
            this.g = graphics;
        }

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x + 30, y + 30);
            g.DrawLine(myPen, x, y, x - 30, y + 30);
            g.DrawLine(myPen, x + 30, y + 30, x-30, y + 30);
            g.DrawLine(myPen, x + 30, y+30, x+30, y + 60);
            g.DrawLine(myPen, x - 30, y + 30, x - 30, y + 60);
            g.DrawLine(myPen, x + 30, y + 60, x - 30, y + 60);
        }
    }
}
