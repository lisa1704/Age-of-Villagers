using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabHouse : CompositeShapes
    {
        
        public ArabHouse(Point point)
        {
            Point point1 = point;
            Point left = new Point(point1.X - 10, point1.Y + 16);
            Point right = new Point(point1.X + 10, point1.Y + 16);
            Point cornerUp = new Point(point1.X + 14, point1.Y);
            Point corner = new Point(point1.X + 12, point1.Y - 8);

            addshapes(new Triangle(point1, left, right));
            addshapes(new Rectangleshape(point1, right, corner, cornerUp));
           
        }

        
            
    }
}
