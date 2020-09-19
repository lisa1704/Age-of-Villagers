using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Triangle : AbstractShape
    {
        public Triangle(Point P1, Point P2, Point P3)
        {
            addShape(new Line(P1, P2));
            addShape(new Line(P2, P3));
            addShape(new Line(P3, P1));
        }
    }
}
