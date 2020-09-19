using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class ArabBedouinsTree : ITree
    {
        int x, y;
        private readonly Graphics g;
        Pen myPen = new Pen(Color.Black);
        public ArabBedouinsTree(Graphics graphics)
        {
            this.g = graphics;
        }
        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g.DrawLine(myPen, x, y, x + 4, y);
            g.DrawLine(myPen, x, y, x, y+24);
            g.DrawLine(myPen, x, y+24, x + 4, y+24);
            g.DrawLine(myPen, x+4, y, x + 4, y+24);
            
            g.DrawLine(myPen, x, y, x - 24, y - 24);
            g.DrawLine(myPen, x+1, y, x - 12, y - 24);
            g.DrawLine(myPen, x+2, y, x + 12, y - 24);
            g.DrawLine(myPen, x+3, y, x + 24, y - 24);
        }
    }
}
