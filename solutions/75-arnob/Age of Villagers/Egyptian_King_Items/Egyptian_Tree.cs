using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Egyptian_Tree : CompositeShaping
    {
        public Egyptian_Tree(Point _point)
        {
            Point startPoint = new Point(_point.X, _point.Y);
            Point pt1 = new Point(_point.X - 3, _point.Y - 8);
            Point pt2 = new Point(_point.X + 3, _point.Y - 8);
            Point pt3 = new Point(_point.X - 5, _point.Y - 16);
            Point pt4 = new Point(_point.X + 4, _point.Y - 17);
            Point pt5 = new Point(_point.X - 8, _point.Y - 14);
            Point pt6 = new Point(_point.X - 1, _point.Y - 17);
            Point pt7 = new Point(_point.X + 1, _point.Y - 16);
            Point pt8 = new Point(_point.X + 8, _point.Y - 16);


            AddComponent(new Line(startPoint, pt1));
            AddComponent(new Line(startPoint, pt2));
            AddComponent(new Line(pt1, pt3));
            AddComponent(new Line(pt2, pt4));
            AddComponent(new Line(pt1, pt5));
            AddComponent(new Line(pt1, pt6));
            AddComponent(new Line(pt2, pt7));
            AddComponent(new Line(pt2, pt8));

        }
    }
}     
