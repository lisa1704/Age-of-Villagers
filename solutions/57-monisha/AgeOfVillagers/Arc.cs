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
            public BDTree(Point MPt, Point topLeft)
            {
                Point topRight = new Point(MPt.X +20, MPt.Y);
                Point bottomRight = new Point(MPt.X + 50, MPt.Y+15);

                AddComp(new ShapeRectangle(topLeft, bottomRight));
                //AddComp(new ShapeEllipse(MPt,55, 50,0,360));
            }

        }
    }
}

