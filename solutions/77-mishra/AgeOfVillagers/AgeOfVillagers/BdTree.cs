using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdTree : CompositeShapes
    {
        public BdTree(Point point)
        {
            Point point1 = point;
            Point point2 = new Point(point1.X + 8, point1.Y + 8);
            Point point3 = new Point(point1.X + 8, point1.Y + 24);
            addshapes(new Line(point2, point3));
            addshapes(new Circle(point1, 16, 16));
        }
        
    }
}
