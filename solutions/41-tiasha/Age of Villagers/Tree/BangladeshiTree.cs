using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Tree
{
    public class BangladeshiTree : CompositeShape
    {
        public BangladeshiTree(Point p, ElementSize sz)
        {
            Point topleft = p;
            Point topright = new Point(p.X + 2, p.Y);
            Point bottomleft = new Point(p.X, p.Y + sz.height / 2);
            Point bottomRight = new Point(p.X + 2, p.Y + sz.height / 2);

            AddComponent(new Rectangle(topleft, topright, bottomleft, bottomRight));
            AddComponent(new Arc(p.X - sz.width / 3, p.Y - sz.height / 2, sz.height / 2, sz.width, 0, 360));
        }

    }
}
