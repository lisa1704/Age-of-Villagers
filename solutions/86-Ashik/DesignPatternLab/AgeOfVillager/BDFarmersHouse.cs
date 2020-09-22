using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class BDFarmersHouse : IHouse
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
            
            //16*16 px
            g.DrawLine(myPen, x, y, x + 16, y);
            g.DrawLine(myPen, x, y, x, y + 8);
            g.DrawLine(myPen, x + 16, y, x + 16, y + 8);
            g.DrawLine(myPen, x, y + 8, x + 16, y + 8);

            g.DrawLine(myPen, x, y, x + 8, y - 8);
            g.DrawLine(myPen, x+16, y, x + 8, y - 8);
        }
    }
}
