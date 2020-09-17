using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BaseLine:IGraphicShape
    {
        private readonly Point _p1, _p2;

        public BaseLine(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public void draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, _p1, _p2);
        }
    }
}
