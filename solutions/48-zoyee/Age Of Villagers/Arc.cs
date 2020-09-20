using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class Arc : IShape
    {
        public int x, y;
        public float width;
        private float height;
        public float i_angle, s_angle;

        public Arc(int x, int y, float width, float height, float i_angle, float s_angle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.i_angle = i_angle;
            this.s_angle = s_angle;
        }
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, i_angle, s_angle);
        }
    }
    public class Elipse_Shape : CompositeShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public Elipse_Shape(Point TopLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.BottomRight = BottomRight;
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y, 0, 360));
        }
    }
}
