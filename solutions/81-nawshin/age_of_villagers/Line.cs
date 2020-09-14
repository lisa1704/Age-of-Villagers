using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Line : IShape
    {
        private readonly Point point1;
        private readonly Point point2;
        public Line(Point pt1, Point pt2)
        {
            point1 = pt1;
            point2 = pt2;
        }
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkBlue);
            g.DrawLine(p, point1, point2);
        }

    }
}
