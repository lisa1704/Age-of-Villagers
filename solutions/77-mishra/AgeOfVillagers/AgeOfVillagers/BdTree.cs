using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdTree : IShape
    {
        public BdTree(Point p)
        {
            
        }
        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Green);

            graphics.DrawArc(pen, p.X, p.Y, 16, 24, 90, 360);
            graphics.DrawLine(pen, p.X + 8, p.Y, p.X + 8, p.Y + 16);
        }
    }
}
