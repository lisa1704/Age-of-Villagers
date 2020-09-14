using System.Drawing;

namespace AgeOfVillagers
{
    class Arc : IShapeItem
    {
        private readonly Point point1;
        private readonly Point point2;
        private float x, y, width, height, startAngle, sweepAngle;
        

        public Arc(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void Paint(Graphics g,Pen p)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen,x, y, width, height, startAngle, sweepAngle);
        }
        public class ShapeEllipse : CompositeShape
        {
            private readonly Point _topleft;
            private readonly Point _bottomright;

            public ShapeEllipse(Point tLeft, Point bRight)
            {
                _topleft = tLeft;
                _bottomright = bRight;
                AddComp(new Arc(_topleft.X, _topleft.Y, _bottomright.X - _topleft.X, _bottomright.Y - _topleft.Y, 0, 360));
            }
        }
        public class BDTree : CompositeShape
        {
            public BDTree(Point MPt)
            {
                Point topRight = new Point(MPt.X +20, MPt.Y);
                Point bottomRight = new Point(MPt.X +25, MPt.Y+50);
                Point topPt = new Point(MPt.X + 40, MPt.Y+40);
                Point RTopLeft = new Point(MPt.X +20, MPt.Y +20);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new ShapeEllipse(MPt,topPt));
            }

        }
        public class ArabTree : CompositeShape
        {
            public ArabTree(Point MPt)
            {
                Point topRight = new Point(MPt.X + 20, MPt.Y);
                Point bottomRight = new Point(MPt.X + 25, MPt.Y + 50);
                Point L1topPt = new Point(MPt.X , MPt.Y -35);
                Point L2topPt = new Point(MPt.X, MPt.Y - 25);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new Line(RTopLeft, L1topPt));
                AddComp(new Line(topRight, L2topPt));
            }

        }
    }
}

