using System.Drawing;

namespace AgeOfVillagers
{
    partial class ShapeArc : IShapeItem
    {
        public float x, y, width, height, startAngle, sweepAngle;        

        public ShapeArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
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
            public Point _topleft;
            public Point _bottomright;

            public ShapeEllipse(Point tLeft, Point bRight)
            {
                _topleft = tLeft;
                _bottomright = bRight;
                AddComp(new ShapeArc(_topleft.X, _topleft.Y, _bottomright.X - _topleft.X, _bottomright.Y - _topleft.Y, 0, 360));
            }
        }



    }
}

