using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouinTree:CompositeShape
    {
        public ArabBedouinTree(Point MainPoint)
        {
            Point TopRight = new Point(MainPoint.X + 22, MainPoint.Y + 20);
            Point BottomRight = new Point(MainPoint.X + 25, MainPoint.Y + 80);
            Point LeftTopPoint1 = new Point(MainPoint.X, MainPoint.Y - 15);
            Point LeftTopPoint2 = new Point(MainPoint.X + 40, MainPoint.Y - 15);
            Point LeftTopPoint3 = new Point(MainPoint.X + 40, MainPoint.Y + 15);
            Point LeftTopPoint4 = new Point(MainPoint.X + 40, MainPoint.Y - 50);
            Point LeftTopPoint5 = new Point(MainPoint.X + 40, MainPoint.Y);
            Point RightTopLeftPoint = new Point(MainPoint.X + 20, MainPoint.Y + 20);

            AddComponent(new Rectangle(RightTopLeftPoint, BottomRight));
            AddComponent(new Line(RightTopLeftPoint, LeftTopPoint1));
            //AddComponent(new Line(TopRight, LeftTopPoint1));
            AddComponent(new Line(TopRight, LeftTopPoint2));
            AddComponent(new Line(TopRight, LeftTopPoint3));
            AddComponent(new Line(TopRight, LeftTopPoint4));
            AddComponent(new Line(TopRight, LeftTopPoint5));
        }
    }
}
