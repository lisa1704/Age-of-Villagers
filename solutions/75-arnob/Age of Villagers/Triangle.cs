using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Triangle : CompositeShaping
    {
        public Triangle(Point top, Point baseLeft, Point baseRight)
        {
            AddComponent(new Line(top, baseLeft));
            AddComponent(new Line(baseLeft, baseRight));
            AddComponent(new Line(baseRight, top));
        }
    }
}
