using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Bangladeshi_Farmer
{
    class BDfarmer_Tree
    {
        public BDfarmer_Tree(Point point)
        {
            Point TopPoint = new Point(point.X + 60, point.Y + 70);
            Point BottomRight = new Point(point.X + 28, point.Y + 100);
            Point TopLeft = new Point(point.X + 33, point.Y + 45);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new EllipseShape(point, TopPoint));
        }
    }
}
