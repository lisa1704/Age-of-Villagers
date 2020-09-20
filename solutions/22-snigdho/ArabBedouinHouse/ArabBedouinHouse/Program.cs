using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouinHouse : Composite
    {
        public ArabBedouinHouse(Point point)
        {
            Point point1 = new Point(point.X - 20, point.Y + 40);
            Point point2 = new Point(point.X + 20, point.Y + 40);
            Point point3 = new Point(point.X + 28, point.Y - 10);
            Point point4 = new Point(point2.X + 30, point2.Y - 15);


            AddComponent(new Triangle(point, point1, point2));
            AddComponent(new Line(point, point3));
            AddComponent(new Line(point2, point4));
            AddComponent(new Line(point3, point4));

        }
    }
}
