using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Age_of_villagers.Shape
{
    class Arc : IShape
    {
        private readonly Point point;
        private float x, y, width, height, start_Angle, sweep_Angle;
        public Arc(Point topLeft, Point bottomRight)
        {
            x = topLeft.X;
            y = topLeft.Y;
            width = bottomRight.X - topLeft.X;
            height = bottomRight.Y - topLeft.Y;
            start_Angle = 0;
            sweep_Angle = 180;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, start_Angle, sweep_Angle);
        }
    }
}
