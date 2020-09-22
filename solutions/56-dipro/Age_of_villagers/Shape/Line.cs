using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers.Shape
{
    class Line : IShape 
    {
        private Point point_1, point_2;
        public Line(Point point_1, Point point_2)
        {
            this.point_1 = point_1;
            this.point_2 = point_2;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point_1, point_2);
        }
    }
}
