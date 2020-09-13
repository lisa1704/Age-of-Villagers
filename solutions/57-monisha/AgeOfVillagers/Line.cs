using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Line : IShapeItem
    {
        private readonly Point point1;
        private readonly Point point2;
        public Line(Point pt1, Point pt2)
        {
            point1 = pt1;
            point2 = pt2;
        }
        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, point1, point2);
        }
    }

    public class ShapeRectangle : IShapeItem
    {
        private readonly Point topLeft;
        private readonly Point bottomRight;
        public ShapeRectangle(Point tLeft,Point bRight)
        {
            topLeft= tLeft;
            bottomRight = bRight;

        }
        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, topLeft.X, topLeft.Y, bottomRight.X, topLeft.Y);
            g.DrawLine(pen, topLeft.X, topLeft.Y, topLeft.X, bottomRight.Y);
            g.DrawLine(pen, topLeft.X, bottomRight.Y, bottomRight.X, bottomRight.Y);
            g.DrawLine(pen, bottomRight.X, topLeft.Y, bottomRight.X, bottomRight.Y);

        }
    }

    class Arc : IShapeItem
    {
        private readonly Point point1;
        private readonly Point point2;
        public int x, y, width, height, startAngle, sweepAngle;

        public Arc()
        {

        }
        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen,x, y, width, height, startAngle, sweepAngle);
        }
    }
}

