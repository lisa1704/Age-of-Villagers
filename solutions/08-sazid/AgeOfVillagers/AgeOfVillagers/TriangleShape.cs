using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class TriangleShape : AdvancedShape
    {
        public TriangleShape(Point p1, Point p2, Point p3)
        {
            addShape(new LineShape(p1, p2));
            addShape(new LineShape(p2, p3));
            addShape(new LineShape(p3, p1));
        }
    }
}
