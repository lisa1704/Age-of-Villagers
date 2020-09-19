using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers.Shapes
{
    class Circle : IShape
    {
        private Point x;
        private int y, width, height, radius;
        Graphics g;
        Pen pen;
        public Circle(Graphics g, Pen pen, Point x, int y, int width, int height, int radius)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.radius = radius;
            this.g = g;
            this.pen = pen;
        }
        public void DrawShape()
        {
            g.DrawArc(pen, x.X - 25, x.Y - 25, y, width, height, radius);
        }
    }
}
