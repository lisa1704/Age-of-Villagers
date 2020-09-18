using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgeOfVillagers90
{
    public class BangladeshFarmersTree : CompositeShape
    {
        public BangladeshFarmersTree(Point MainPoint)
        {
            Point rootPoint = new Point(MainPoint.X + 3, MainPoint.Y + 16);
            Point TopPoint1 = new Point(MainPoint.X - 8, MainPoint.Y - 10);
            Point TopPoint2 = new Point(MainPoint.X + 8, MainPoint.Y + 8);

            AddComponent(new Rectangle(MainPoint, rootPoint));
            AddComponent(new ShapeEllipse(TopPoint1, TopPoint2));
        }
    }
}
