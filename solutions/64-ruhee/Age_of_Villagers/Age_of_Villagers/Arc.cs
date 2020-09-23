using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Age_of_Villagers.Age_of_Villagers
{
    class Arc : IShape
    {
        public int x, y;
        private float width, height, StartAngle, SweepAngle;


        public Arc(int x, int y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.StartAngle = startAngle;
            this.SweepAngle = sweepAngle;
        }

        public void Draw(Graphics g,Pen pen)
        {
            g.DrawArc(pen, x, y, width, height, StartAngle, SweepAngle);
        }
    }

    public class Ellipse : CShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;

        public Ellipse(Point TopLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.BottomRight = BottomRight;
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y, 0, 360));
        }

        public void Draw(Graphics g,Pen pen)
        {
            g.DrawEllipse(pen, TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
        }
    }
}
