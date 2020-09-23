using System.Drawing;

namespace AOV
{
    class ArabTree : CompoundShape
    {
        public ArabTree(Point clicked)
        {
            Point topLeftCorner = new Point(clicked.X, clicked.Y);
            Point topCenter = new Point(clicked.X+1, clicked.Y);
            Point topRightCorner = new Point(clicked.X + 2, clicked.Y);
            Point bottomRightCorner = new Point(clicked.X + 2, clicked.Y + 12);
            Point x1 = new Point(topLeftCorner.X - 7, clicked.Y - 6);
            Point x2 = new Point(topLeftCorner.X - 3, clicked.Y - 10);
            Point x3 = new Point(topCenter.X , clicked.Y - 12);
            Point x4 = new Point(topRightCorner.X + 3, clicked.Y - 10);
            Point x5 = new Point(topRightCorner.X + 7, clicked.Y - 6);

            addShape(new Rectangle(topLeftCorner, bottomRightCorner));
            addShape(new DrawLine(topCenter, x3));            
            addShape(new DrawLine(topLeftCorner, x1));
            addShape(new DrawLine(topLeftCorner, x2));
            addShape(new DrawLine(topRightCorner, x4));
            addShape(new DrawLine(topRightCorner, x5));
        }
    }
}
