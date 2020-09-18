using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        public float x, y, width, height, angle_1, angle_2;

        public Arc(float x, float y, float width, float height, float angle_1, float angle_2)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.angle_1 = angle_1;
            this.angle_2 = angle_2;
        }

        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, angle_1, angle_2);
        }
    }

    public class Ellipse : Composite
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;

        public Ellipse(Point TopLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.BottomRight = BottomRight;
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X-TopLeft.X, BottomRight.Y-TopLeft.Y, 0, 360));
        }
    }
}
