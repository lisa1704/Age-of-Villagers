using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgeOfVillagers90
{
    public class ArabBedouinTree : CompositeShape
    {
        public ArabBedouinTree(Point MainPoint)
        {
            Point rootPoint = new Point(MainPoint.X + 4, MainPoint.Y + 12);
            Point midPoint = new Point(MainPoint.X + 2, MainPoint.Y + 0);
            Point leafPoint1 = new Point(MainPoint.X + 8 , MainPoint.Y - 8);
            Point leafPoint2 = new Point(MainPoint.X + 5, MainPoint.Y - 10);
            Point leafPoint3 = new Point(MainPoint.X + 2, MainPoint.Y - 12);
            Point leafPoint4 = new Point(MainPoint.X - 5, MainPoint.Y - 10);
            Point leafPoint5 = new Point(MainPoint.X - 8, MainPoint.Y -8);
            

            AddComponent(new Rectangle(MainPoint, rootPoint));
            AddComponent(new Line(midPoint, leafPoint1));
            AddComponent(new Line(midPoint, leafPoint2));
            AddComponent(new Line(midPoint, leafPoint3));
            AddComponent(new Line(midPoint, leafPoint4));
            AddComponent(new Line(midPoint, leafPoint5));
        }

    }
}
