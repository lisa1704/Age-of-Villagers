using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BasicShapeFactory
    {
        public BasicShapes GetShape(Graphics g, Pen pen, Point point, int height, int width,string hint)
        {
            if (hint.Equals(Constants.RECT_HINT))
                return new Rectangle(g, pen, point, height, width);
            else if (hint.Equals(Constants.TRIANGLE_HINT))
                return new Triangle(g, pen, point, height, width);
            else if(hint.Equals(Constants.UNEQUAL_NONAGON_HINT))
                return new CrookedOctagon(g, pen, point, height, width);
            else if (hint.Equals(Constants.OVAL_HINT))
            {
                return new Oval(g, pen, point, height, width);
            }
            return null;
        }

        
    }
}
