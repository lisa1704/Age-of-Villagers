using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class BangladeshiHouse : CompositeShape
    {
        public BangladeshiHouse(Point p, ElementSize sz)
        {
            Point top = new Point(p.X + (sz.width / 2), p.Y - 6);
            Point topLeft = p;
            Point bottomLeft = new Point(p.X, p.Y + (sz.height - 6));
            Point topRight = new Point(p.X + sz.width, p.Y);
            Point bottomRight = new Point(p.X + sz.width, p.Y + (sz.height - 6));

            AddComponent(new Triangle(top, topLeft, topRight));
            AddComponent(new Rectangle(topLeft, topRight, bottomLeft, bottomRight));
        }
    }
}
