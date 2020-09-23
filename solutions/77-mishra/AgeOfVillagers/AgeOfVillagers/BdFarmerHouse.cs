using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerHouse : CompositeShapes
    {
        public BdFarmerHouse(Point point)
        {
            Point point1 = point;
            Point point2 = new Point(point1.X + 8, point1.Y + 16);
            Point point3 = new Point(point1.X - 8, point1.Y + 16);
            Point point4 = new Point(point1.X - 8, point1.Y + 24);
            Point point5 = new Point(point1.X + 8, point1.Y + 24);

            addshapes(new Triangle(point1, point2, point3));
            addshapes(new Rectangleshape(point2, point3, point4, point5));
        }
        
    }
}
