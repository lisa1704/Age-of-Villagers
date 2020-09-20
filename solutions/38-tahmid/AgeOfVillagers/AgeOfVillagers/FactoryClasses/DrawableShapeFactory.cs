using AgeOfVillagers.AbstractClass;
using System.Drawing;

namespace AgeOfVillagers
{
    class DrawableShapeFactory
    {
        public DrawableShapes GetDrawableShape(Graphics g, Pen pen, Point point, int height, int width,string hint)
        {
            
            
             if(hint.Equals(Constants.UNEQUAL_NONAGON_HINT))
                return new UnequilateralNonagon(g, pen, point, height, width);
            else if (hint.Equals(Constants.OVAL_HINT))
            {
                return new Oval(g, pen, point, height, width);
            }
            
            
            return null;
        }

        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point topPoint, Point rightPoint,Point leftPoint, string hint)
        {
            if (hint.Equals(Constants.TRIANGLE_HINT))
                return new Triangle(topPoint, rightPoint, leftPoint, graphics, pen);
            return null;
            
        }

        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point topLeftPoint, Point topRightPoint, Point bottomLeftPoint, Point bottomRighttPoint, string hint)
        {
            if (hint.Equals(Constants.RECT_HINT))
                return new Quadrangle(topLeftPoint, topRightPoint, bottomLeftPoint, bottomRighttPoint, graphics, pen);
            return null;

        }



    }
}
