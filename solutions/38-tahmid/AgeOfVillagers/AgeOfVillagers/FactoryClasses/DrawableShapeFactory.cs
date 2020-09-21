using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Drawable_Shape_Extending_Classes;
using AgeOfVillagers.Shape_implementing_Classes;
using System.Drawing;

namespace AgeOfVillagers
{
    class DrawableShapeFactory
    {
        public DrawableShapes GetDrawableShape(Graphics g, Pen pen, Point point,int startingAngle,int endingAngle, int height, int width, string hint)
        {


            if (hint.Equals(Constants.CIRCULAR_HINT))
            {
                return new CircularShape(g, pen, point, height, width,startingAngle,endingAngle);
            }


            return new NullClass(hint);
        }

        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point topPoint, Point rightPoint, Point leftPoint, string hint)
        {
            if (hint.Equals(Constants.TRIANGLE_HINT))
            {
                return new Triangle(topPoint, rightPoint, leftPoint, graphics, pen);
            }
            else if (hint.Equals(Constants.VSHAPE_HINT))
            {
                return new Vshape(topPoint, rightPoint, leftPoint, graphics, pen);
            }
            return new NullClass(hint);

        }

        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point topLeftPoint, Point topRightPoint, Point bottomLeftPoint, Point bottomRighttPoint, string hint)
        {
            if (hint.Equals(Constants.RECT_HINT))
                return new Quadrangle(topLeftPoint, topRightPoint, bottomLeftPoint, bottomRighttPoint, graphics, pen);
            return new NullClass(hint);

        }
        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point startingPoint, Point topLeftPoint, Point topMidLeftPoint, Point topMidPoint, Point topMidRightPoint, Point bottomLeftPoint, Point bottomMidLeftPoint, Point bottomMidRightPoint, Point endPoint, string hint)
        {
            if (hint.Equals(Constants.UNEQUAL_NONAGON_HINT))
                return new UnequilateralNonagon(startingPoint, topLeftPoint, topMidLeftPoint, topMidPoint, topMidRightPoint, bottomLeftPoint, bottomMidLeftPoint, bottomMidRightPoint, endPoint, graphics, pen);
            return new NullClass(hint);
        }

        public DrawableShapes GetDrawableShape(Graphics graphics, Pen pen, Point startingPoint, Point endPoint, string hint)
            {
                if (hint.Equals(Constants.LINE_HINT))
                    return new Line(startingPoint, endPoint, graphics, pen);
                return new NullClass(hint);

            

            }
    }
}
