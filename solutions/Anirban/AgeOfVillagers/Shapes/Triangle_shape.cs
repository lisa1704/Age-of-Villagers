using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Triangle_shape : IShapes
    {
        public Point apex, base1, base2;

        public Triangle_shape(Point top, Point bottom1, Point bottom2)
        {
            apex = top;
            base1 = bottom1;
            base2 = bottom2;

        }

        public void Draw_shapes(Point pt, Graphics g, Pen p)
        {
            g.DrawLine(p, apex, base1);
            g.DrawLine(p, base1, base2);
            g.DrawLine(p, base2, apex);

        }
    }
}
