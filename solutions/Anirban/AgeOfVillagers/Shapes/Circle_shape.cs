using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Circle_shape : IShapes
    {

        public Point centre;
        int height, width;


        public Circle_shape(Point p, int archeight, int arcWidth)
        {
            centre = p;
            height = archeight;
            width = arcWidth;
        }

        public void Draw_shapes(Point pt, Graphics g, Pen p)
        {
            g.DrawArc(p, centre.X-12, centre.Y-20, width, height, 0, 360);
        }
    }
}
