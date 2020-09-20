using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabTree : IShape
    {
        
       

        public ArabTree(Point point)
        {

        }
        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.Green);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y + 14);
            g.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y + 3);
            g.DrawLine(pen, p.X, p.Y, p.X + 5, p.Y + 6);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y + 10);
            g.DrawLine(pen, p.X, p.Y, p.X - 5, p.Y + 6);
            g.DrawLine(pen, p.X, p.Y, p.X - 8, p.Y - 3);
        }
    }
}
