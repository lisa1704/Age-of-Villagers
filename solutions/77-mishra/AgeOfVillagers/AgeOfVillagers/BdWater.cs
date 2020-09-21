using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdWater : CompositeShapes
    {
        private Point point;
        public BdWater(Point point)
        {
            Point point1 = point;
            Point point2 = new Point(point1.X + 8, point1.Y - 8);
            Point point3 = new Point(point1.X + 6, point1.Y + 9);
            Point point4 = new Point(point1.X + 10, point1.Y - 9);
            Point point5 = new Point(point1.X + 10, point1.Y - 7);
            Point point6 = new Point(point1.X + 11, point1.Y + 4);
            Point point7 = new Point(point1.X + 19, point1.Y + 11);
            Point point8 = new Point(point1.X + 27, point1.Y - 4);
            Point point9 = new Point(point1.X + 18, point1.Y - 11);

            addshapes(new Line(point1, point2));
            addshapes(new Line(point1, point3));
            addshapes(new Line(point3, point6));
            addshapes(new Line(point6, point7));
            addshapes(new Line(point2, point4));
            addshapes(new Line(point4, point5));
            addshapes(new Line(point5, point9));
            addshapes(new Line(point9, point8));
            addshapes(new Line(point8, point7));
        }
       

        
    }
}
