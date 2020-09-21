using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class ArabianHouse : CompositeShape
    {
        public ArabianHouse(Point p, ElementSize sz)
        {
            var topLeft = p;

            var bottomLeft = new Point(p.X - sz.width * 5 / 16, p.Y + sz.height * 5 / 8);
            var bottomMid = new Point(p.X + sz.width * 5 / 16, p.Y + sz.height * 5 / 8);
            var bottomRight = new Point(bottomMid.X + sz.width * 6 / 16, bottomMid.Y - sz.height * 6 / 16);
            var topRight = new Point(p.X + sz.width * 6 / 16, p.Y - sz.height * 6 / 16);



            AddComponent(new Triangle(topLeft, bottomLeft, bottomMid));
            AddComponent(new Rectangle(topLeft, topRight, bottomMid, bottomRight));
        }
    }
}
