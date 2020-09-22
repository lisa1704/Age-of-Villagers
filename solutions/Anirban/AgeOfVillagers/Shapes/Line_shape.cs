using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Line_shape : IShapes
    {
        public Point pt1, pt2;

        public Line_shape(Point point1, Point point2)
        {
            pt1 = point1;
            pt2 = point2;
        }
        
        public void Draw_shapes(Point pt, Graphics g, Pen p)
        {
            g.DrawLine(p, pt1, pt2);
        }
    }
}
