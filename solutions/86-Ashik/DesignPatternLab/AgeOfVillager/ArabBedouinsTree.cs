using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class ArabBedouinsTree : ITree
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
            g.DrawLine(myPen, x, y, x + 3, y);
            g.DrawLine(myPen, x, y, x, y-12);
            g.DrawLine(myPen, x+3, y, x + 3, y-12);
            g.DrawLine(myPen, x, y-12, x + 3, y-12);
            
            g.DrawLine(myPen, x, y-12, x - 6, y - 24);
            g.DrawLine(myPen, x+1, y-12, x - 3, y - 24);
            g.DrawLine(myPen, x+1, y-12, x + 3, y - 24);
            g.DrawLine(myPen, x+2, y-12, x + 6, y - 24);
        }
    }
}
