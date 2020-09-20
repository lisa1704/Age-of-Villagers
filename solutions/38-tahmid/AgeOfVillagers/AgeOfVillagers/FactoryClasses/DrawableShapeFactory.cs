using AgeOfVillagers.AbstractClass;
using System.Drawing;

namespace AgeOfVillagers
{
    class DrawableShapeFactory
    {
        public DrawableShapes GetDrawableShape(Graphics g, Pen pen, Point point, int height, int width,string hint)
        {
            
            
             if(hint.Equals(Constants.UNEQUAL_NONAGON_HINT))
                return new CrookedOctagon(g, pen, point, height, width);
            else if (hint.Equals(Constants.OVAL_HINT))
            {
                return new Oval(g, pen, point, height, width);
            }
            
            
            return null;
        }

        public DrawableShapes GetDrawableShape(Graphics g, Pen pen, Point topPoint, Point rightPoint,Point leftPoint, string hint)
        {
            if (hint.Equals(Constants.TRIANGLE_HINT))
                new Triangle(topPoint, rightPoint, leftPoint);
            return null;
            
        }

        public DrawableShapes GetDrawableShape(Graphics g, Pen pen, Point topLeftPoint, Point topRightPoint, Point bottomLeftPoint, Point bottomRighttPoint, string hint)
        {
            if (hint.Equals(Constants.RECT_HINT))
                new Quadrangle(topLeftPoint,topRightPoint,bottomLeftPoint,bottomRighttPoint);
            return null;

        }



    }
}
