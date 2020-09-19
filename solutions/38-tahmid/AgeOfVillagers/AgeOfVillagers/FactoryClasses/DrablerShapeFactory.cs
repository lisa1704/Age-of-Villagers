using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Drawable_Shape_Extending_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class DrablerShapeFactory
    {
        public DrawableShapes GetDrableShape(Graphics g, Pen pen, Point point, int height, int width,string hint)
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

        public DrawableShapes GetDrableShape(Graphics g, Pen pen, Point firstPoint, Point secondPoint, int height, int width, string hint)
        {
            if (hint.Equals(Constants.PARALELLOGRAM_HINT))
            {
                return new Paralellogram(g, pen, firstPoint,secondPoint, height, width);
            }
            return null;
        }



        }
}
