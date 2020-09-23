using System.Drawing;

namespace AOV
{
    class BdWaterSource : CompoundShape
    {
        public BdWaterSource(Point clicked)
        {
            Point p1 = new Point(clicked.X, clicked.Y);
            Point p2 = new Point(clicked.X + 5, clicked.Y - 2);
            Point p3 = new Point(clicked.X + 6, clicked.Y);
            Point p4 = new Point(clicked.X + 12, clicked.Y - 5);
            Point p5 = new Point(clicked.X + 19, clicked.Y);
            Point p6 = new Point(clicked.X + 17, clicked.Y + 9);
            Point p7 = new Point(clicked.X + 7, clicked.Y + 5);
            Point p8 = new Point(clicked.X, clicked.Y + 11);
            Point p9 = new Point(clicked.X - 5, clicked.Y + 7);

            addShape(new DrawLine(p1, p2));
            addShape(new DrawLine(p2, p3));
            addShape(new DrawLine(p3, p4));
            addShape(new DrawLine(p4, p5));
            addShape(new DrawLine(p5, p6));
            addShape(new DrawLine(p6, p7));
            addShape(new DrawLine(p7, p8));
            addShape(new DrawLine(p8, p9));
            addShape(new DrawLine(p9, p1));

        }
    }
}
