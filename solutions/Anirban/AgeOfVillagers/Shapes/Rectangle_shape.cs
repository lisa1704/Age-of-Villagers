using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Rectangle_shape : IShapes
    {
        public Point pt1, pt2, pt3, pt4;
        
        public Rectangle_shape(Point point1, Point point2, Point point3, Point point4)
        {
            pt1 = point1;
            pt2 = point2;
            pt3 = point3;
            pt4 = point4;
        }

        public void Draw_shapes(Point pt, Graphics g, Pen p)
        {
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt1);
        }
    }
}
