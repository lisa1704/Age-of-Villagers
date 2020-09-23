using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace AgeOfVillagers.Inuit_Hunters
{
    public class InuitHuntersHouse : Composite
    {
        public InuitHuntersHouse(Point point)
        {
            Point point1 = new Point(point.X - 35, point.Y - 30);
            Point point2 = new Point(point.X - 10, point.Y - 10);
            Point LeftBottom = new Point(point.X - 35, point.Y);
            Point RightBottom = new Point(point.X + 35, point.Y);
            Point LeftBottom = new Point(point.X - 7, point.Y + 7);
            Point RightBottom = new Point(point.X + 7, point.Y + 7);

            AddComponent(new Line(LeftBottom, RightBottom));
            AddComponent(new Arc(point.X - 10, point.Y - 10, 20, 20, 200.0F, 200.0F));
            AddComponent(new Arc(point.X - 40, point.Y - 40, 80, 80, 200.0F, 200.0F));
            AddComponent(new Arc(point.X - 4, point.Y + 5, 7, 7, 200.0F, 200.0F));
            AddComponent(new Arc(point.X - 8, point.Y, 16, 16, 200.0F, 200.0F));
        }
    }
}
