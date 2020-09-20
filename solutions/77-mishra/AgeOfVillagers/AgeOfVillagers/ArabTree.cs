using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabTree : IShape
    {
        public ArabTree(Point p)
        {

        }
        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Green);
            graphics.DrawLine(pen, p.X, p.Y, p.X, p.Y + 14);
            graphics.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y + 3);
            graphics.DrawLine(pen, p.X, p.Y, p.X + 5, p.Y + 6);
            graphics.DrawLine(pen, p.X, p.Y, p.X, p.Y + 10);
            graphics.DrawLine(pen, p.X, p.Y, p.X - 5, p.Y + 6);
            graphics.DrawLine(pen, p.X, p.Y, p.X - 8, p.Y - 3);
        }
    }
}
